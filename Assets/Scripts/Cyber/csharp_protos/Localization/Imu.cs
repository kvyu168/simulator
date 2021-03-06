// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: modules/localization/proto/imu.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Apollo.Localization {

  /// <summary>Holder for reflection information generated from modules/localization/proto/imu.proto</summary>
  public static partial class ImuReflection {

    #region Descriptor
    /// <summary>File descriptor for modules/localization/proto/imu.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ImuReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRtb2R1bGVzL2xvY2FsaXphdGlvbi9wcm90by9pbXUucHJvdG8SE2Fwb2xs",
            "by5sb2NhbGl6YXRpb24aIW1vZHVsZXMvY29tbW9uL3Byb3RvL2hlYWRlci5w",
            "cm90bxolbW9kdWxlcy9sb2NhbGl6YXRpb24vcHJvdG8vcG9zZS5wcm90byJd",
            "CgxDb3JyZWN0ZWRJbXUSJQoGaGVhZGVyGAEgASgLMhUuYXBvbGxvLmNvbW1v",
            "bi5IZWFkZXISJgoDaW11GAMgASgLMhkuYXBvbGxvLmxvY2FsaXphdGlvbi5Q",
            "b3NlYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Apollo.Common.HeaderReflection.Descriptor, global::Apollo.Localization.PoseReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Apollo.Localization.CorrectedImu), global::Apollo.Localization.CorrectedImu.Parser, new[]{ "Header", "Imu" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CorrectedImu : pb::IMessage<CorrectedImu> {
    private static readonly pb::MessageParser<CorrectedImu> _parser = new pb::MessageParser<CorrectedImu>(() => new CorrectedImu());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CorrectedImu> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Apollo.Localization.ImuReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CorrectedImu() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CorrectedImu(CorrectedImu other) : this() {
      Header = other.header_ != null ? other.Header.Clone() : null;
      Imu = other.imu_ != null ? other.Imu.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CorrectedImu Clone() {
      return new CorrectedImu(this);
    }

    /// <summary>Field number for the "header" field.</summary>
    public const int HeaderFieldNumber = 1;
    private global::Apollo.Common.Header header_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Apollo.Common.Header Header {
      get { return header_; }
      set {
        header_ = value;
      }
    }

    /// <summary>Field number for the "imu" field.</summary>
    public const int ImuFieldNumber = 3;
    private global::Apollo.Localization.Pose imu_;
    /// <summary>
    /// Inertial Measurement Unit(IMU)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Apollo.Localization.Pose Imu {
      get { return imu_; }
      set {
        imu_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CorrectedImu);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CorrectedImu other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Header, other.Header)) return false;
      if (!object.Equals(Imu, other.Imu)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (header_ != null) hash ^= Header.GetHashCode();
      if (imu_ != null) hash ^= Imu.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (header_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Header);
      }
      if (imu_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Imu);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (header_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Header);
      }
      if (imu_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Imu);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CorrectedImu other) {
      if (other == null) {
        return;
      }
      if (other.header_ != null) {
        if (header_ == null) {
          header_ = new global::Apollo.Common.Header();
        }
        Header.MergeFrom(other.Header);
      }
      if (other.imu_ != null) {
        if (imu_ == null) {
          imu_ = new global::Apollo.Localization.Pose();
        }
        Imu.MergeFrom(other.Imu);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            if (header_ == null) {
              header_ = new global::Apollo.Common.Header();
            }
            input.ReadMessage(header_);
            break;
          }
          case 26: {
            if (imu_ == null) {
              imu_ = new global::Apollo.Localization.Pose();
            }
            input.ReadMessage(imu_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
