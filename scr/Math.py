import numpy as np
import FileHandlers as FH
import cv2
import imagehash
from PIL import Image


def Sig(x):
    return 1 / (1 + np.exp(-x))


def MSE():
    img0 = cv2.imread("Holdover.jpg")
    img1 = cv2.imread("Frame.jpg")
    err = np.square(np.subtract(img0, img1)).mean()
    print("MSE:", err)


def ImageHash(imageAPath, imageBPath):
    hash0 = imagehash.average_hash(Image.open(imageAPath))
    hash1 = imagehash.average_hash(Image.open(imageBPath))
    cutoff = 5
    try:
        if hash0 - hash1 < cutoff:
            return 0
        else:
            return 1
    except:
        return 2


def UpdateTime(t):
    return "Updated"

