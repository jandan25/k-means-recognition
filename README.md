# k-means-recognition
Recognizing individual flat objects using the method k - means

The application allows you to
object recognition by the k-means method. It is possible to quickly
recognition of an object with already loaded standards (characteristic vectors
contour and convex hull are stored immediately on the disk), the construction
contour and a convex hull for the image (the image is loaded with
camera, it constructs a contour and a convex hull).

To work with images, the [AForge.NET](http://www.aforgenet.com/framework/) library is used. The methods of this
libraries are used to prepare the image for the process
recognition (filtering, binarization, etc.). AForge.NET Library
provides convenient tools for image processing.
```
The application should provide the following functionality:
```
* Image pre-processing:
* Obtaining an object from the camera (AForge.NET);
* Filtering (Median filtering);
* Binarization (Otsu Method);
* selection of the object outline;
* construction of the convex hull of the object: QuickHull;
* obtaining dimensionless features, formed along the contour;
* Obtaining dimensionless features formed by convex
shell;
