import numpy as np
import FileHandlers as FH
import cv2


def Sig(x):
    return 1 / (1 + np.exp(-x))


def MSE(imageA, imageB):
    img1 = cv2.imread(imageA)
    img2 = cv2.imread(imageB)
    err = np.square(np.subtract(img1, img2)).mean()
    return err


def UpdateTime(t):
    return "Updated"

