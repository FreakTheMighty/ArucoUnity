﻿using ArucoUnity.Utilities;

namespace ArucoUnity
{
  /// \addtogroup aruco_unity_package
  /// \{

  namespace Cameras
  {
    /// <summary>
    /// Configurable controller using a <see cref="IArucoCamera"/>.
    /// </summary>
    public interface IArucoCameraController : IConfigurableController
    {
      // Properties

      /// <summary>
      /// Gets or sets the camera to use.
      /// </summary>
      IArucoCamera ArucoCamera { get; set; }
    }
  }

  /// \} aruco_unity_package
}