from bs4 import BeautifulSoup
from urllib.request import urlopen,Request,urlretrieve
import re
import youtube_dl
import sys
import os
import chromagram1
import chordgram

def ytscrape(search,base):
	req = Request(search, headers={'User-Agent':'Mozilla/5.0'})
	lst[:] = []
	url = urlopen(req)
	soup = BeautifulSoup(url, 'lxml')
	for i in soup.find_all('div',{'class':['yt-lockup-content','yt-lockup-meta-info']},limit=10):
		for link,views in zip(i.select('h3 > a'),i.select('ul > li')):
			if views is not None and views.next_sibling is not None:
				lst.append([base+link.get('href'),views.next_sibling.text])
	for i in lst:
		i[1] = int(re.sub(r' views|,','',i[1]))
	lst.sort(key = lambda x:x[1])
	url.close()
	return lst[-1][0]

def dl_from_youtube(yt_lnk,dlpath):
	ydl_opts = {'format':'bestaudio/best','outtmpl':dlpath+'Sample'+'.%(ext)s','postprocessors':[{'key':'FFmpegExtractAudio','preferredcodec':'wav','preferredquality':'192',}]}
	with youtube_dl.YoutubeDL(ydl_opts) as ydl:
		info = ydl.extract_info(yt_lnk, download=True)
		songname = info.get('title', None)
		if os.path.isfile(dlpath+'Sample.wav'):
			print('found')
			file = dlpath+'Sample'+'.wav'
			C = chromagram1.chromagram(file)
			H = chordgram.chordgram(C)
			H1 = chordgram.smoothed_chordgram(H)
			R = chordgram.chord_sequence(H)
			R1 = chordgram.chord_sequence(H1)
			res=chordgram.tostring_chords(R1)
			return res

		else:
			print (dlpath+'Sample.wav')
			print('not found')

def main(song_name,artist_name):
	song = str(song_name) + "karaoke"
	artist = str(artist_name)
	baseurl = 'https://www.youtube.com'
	if sys.platform == 'win32':
		dlpath = os.path.join(os.environ['USERPROFILE'],'Music','spd')
		if not os.path.exists(dlpath):
			os.mkdir(dlpath)
	else:
		#dlpath = '~/Music/' + song + '.wav'
		dlpath = '/Users/meenakshi/Music/'
		
	searchurl = baseurl + '/results?search_query=' + '+' + artist.replace(chr(32),'+') + '+' + song.replace(chr(32),'+')
	D = dl_from_youtube(ytscrape(searchurl,baseurl),dlpath)
	return D


lst = []
