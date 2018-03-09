from parameters import *
import librosa
import librosa.display
import matplotlib.pyplot as plt


def chromagram(file, display=False):
    """
    param file: file path
    param sr: sample rate, default: 44100
    return: chroma features of input audio
    instructions: https://librosa.github.io/librosa/generated/librosa.feature.chroma_cqt.html#librosa.feature.chroma_cqt

    """
    sr = 44100

    # reads audio file starting at [offset] and lasts [duration] seconds
    y, sr = librosa.load(file, sr=sr, offset=offset, duration=duration)

    # Harmonic content extraction
    y_harmonic, y_percussive = librosa.effects.hpss(y)

    # use Constant Q Transform to calculate Pitch Class Profile (PCP), normalized
    chromagram = librosa.feature.chroma_cqt(y=y_harmonic, sr=sr, hop_length=hop_length)

    if display == True:
        plt.figure(figsize=(10, 5))
        librosa.display.specshow(chromagram, sr=sr, x_axis="frames", y_axis="chroma")
        plt.title("Chroma Features")
        plt.colorbar()
        plt.tight_layout()
        plt.show()

    return chromagram
