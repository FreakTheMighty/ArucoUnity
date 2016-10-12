#include "aruco_unity/utility/scalar.hpp"

extern "C" {
  // Constructors & Destructors
  cv::Scalar* au_Scalar_new(double v0, double v1, double v2) {
    return new cv::Scalar(v0, v1, v2);
  }
  
  void au_Scalar_delete(cv::Scalar* scalar) {
    delete scalar;
  }
}