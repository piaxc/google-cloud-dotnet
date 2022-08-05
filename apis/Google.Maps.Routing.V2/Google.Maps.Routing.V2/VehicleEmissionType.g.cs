// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/maps/routing/v2/vehicle_emission_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Maps.Routing.V2 {

  /// <summary>Holder for reflection information generated from google/maps/routing/v2/vehicle_emission_type.proto</summary>
  public static partial class VehicleEmissionTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/maps/routing/v2/vehicle_emission_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static VehicleEmissionTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjJnb29nbGUvbWFwcy9yb3V0aW5nL3YyL3ZlaGljbGVfZW1pc3Npb25fdHlw",
            "ZS5wcm90bxIWZ29vZ2xlLm1hcHMucm91dGluZy52MipkChNWZWhpY2xlRW1p",
            "c3Npb25UeXBlEiUKIVZFSElDTEVfRU1JU1NJT05fVFlQRV9VTlNQRUNJRklF",
            "RBAAEgwKCEdBU09MSU5FEAESDAoIRUxFQ1RSSUMQAhIKCgZIWUJSSUQQA0LQ",
            "AQoaY29tLmdvb2dsZS5tYXBzLnJvdXRpbmcudjJCGFZlaGljbGVFbWlzc2lv",
            "blR5cGVQcm90b1ABWj1nb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29n",
            "bGVhcGlzL21hcHMvcm91dGluZy92Mjtyb3V0aW5n+AEBogIFR01SVjKqAhZH",
            "b29nbGUuTWFwcy5Sb3V0aW5nLlYyygIWR29vZ2xlXE1hcHNcUm91dGluZ1xW",
            "MuoCGUdvb2dsZTo6TWFwczo6Um91dGluZzo6VjJiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Google.Maps.Routing.V2.VehicleEmissionType), }, null, null));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// A set of values describing the vehicle's emission type.
  /// Applies only to the DRIVE travel mode.
  /// </summary>
  public enum VehicleEmissionType {
    /// <summary>
    /// No emission type specified. Default to GASOLINE.
    /// </summary>
    [pbr::OriginalName("VEHICLE_EMISSION_TYPE_UNSPECIFIED")] Unspecified = 0,
    /// <summary>
    /// Gasoline/petrol fueled vehicle.
    /// </summary>
    [pbr::OriginalName("GASOLINE")] Gasoline = 1,
    /// <summary>
    /// Electricity powered vehicle.
    /// </summary>
    [pbr::OriginalName("ELECTRIC")] Electric = 2,
    /// <summary>
    /// Hybrid fuel (such as gasoline + electric) vehicle.
    /// </summary>
    [pbr::OriginalName("HYBRID")] Hybrid = 3,
  }

  #endregion

}

#endregion Designer generated code