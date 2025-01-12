// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/deploy/v1/automation_payload.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Deploy.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/deploy/v1/automation_payload.proto</summary>
  public static partial class AutomationPayloadReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/deploy/v1/automation_payload.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AutomationPayloadReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci9nb29nbGUvY2xvdWQvZGVwbG95L3YxL2F1dG9tYXRpb25fcGF5bG9hZC5w",
            "cm90bxIWZ29vZ2xlLmNsb3VkLmRlcGxveS52MRomZ29vZ2xlL2Nsb3VkL2Rl",
            "cGxveS92MS9sb2dfZW51bXMucHJvdG8ieAoPQXV0b21hdGlvbkV2ZW50Eg8K",
            "B21lc3NhZ2UYASABKAkSEgoKYXV0b21hdGlvbhgCIAEoCRIUCgxwaXBlbGlu",
            "ZV91aWQYAyABKAkSKgoEdHlwZRgEIAEoDjIcLmdvb2dsZS5jbG91ZC5kZXBs",
            "b3kudjEuVHlwZUJqChpjb20uZ29vZ2xlLmNsb3VkLmRlcGxveS52MUIWQXV0",
            "b21hdGlvblBheWxvYWRQcm90b1ABWjJjbG91ZC5nb29nbGUuY29tL2dvL2Rl",
            "cGxveS9hcGl2MS9kZXBsb3lwYjtkZXBsb3lwYmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Cloud.Deploy.V1.LogEnumsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Deploy.V1.AutomationEvent), global::Google.Cloud.Deploy.V1.AutomationEvent.Parser, new[]{ "Message", "Automation", "PipelineUid", "Type" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Payload proto for "clouddeploy.googleapis.com/automation"
  /// Platform Log event that describes the Automation related events.
  /// </summary>
  public sealed partial class AutomationEvent : pb::IMessage<AutomationEvent>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AutomationEvent> _parser = new pb::MessageParser<AutomationEvent>(() => new AutomationEvent());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AutomationEvent> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Deploy.V1.AutomationPayloadReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AutomationEvent() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AutomationEvent(AutomationEvent other) : this() {
      message_ = other.message_;
      automation_ = other.automation_;
      pipelineUid_ = other.pipelineUid_;
      type_ = other.type_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AutomationEvent Clone() {
      return new AutomationEvent(this);
    }

    /// <summary>Field number for the "message" field.</summary>
    public const int MessageFieldNumber = 1;
    private string message_ = "";
    /// <summary>
    /// Debug message for when there is an update on the AutomationRun.
    /// Provides further details about the resource creation or state change.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Message {
      get { return message_; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "automation" field.</summary>
    public const int AutomationFieldNumber = 2;
    private string automation_ = "";
    /// <summary>
    /// The name of the `AutomationRun`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Automation {
      get { return automation_; }
      set {
        automation_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "pipeline_uid" field.</summary>
    public const int PipelineUidFieldNumber = 3;
    private string pipelineUid_ = "";
    /// <summary>
    /// Unique identifier of the `DeliveryPipeline`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string PipelineUid {
      get { return pipelineUid_; }
      set {
        pipelineUid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 4;
    private global::Google.Cloud.Deploy.V1.Type type_ = global::Google.Cloud.Deploy.V1.Type.Unspecified;
    /// <summary>
    /// Type of this notification, e.g. for a Pub/Sub failure.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.Deploy.V1.Type Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AutomationEvent);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AutomationEvent other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Message != other.Message) return false;
      if (Automation != other.Automation) return false;
      if (PipelineUid != other.PipelineUid) return false;
      if (Type != other.Type) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Message.Length != 0) hash ^= Message.GetHashCode();
      if (Automation.Length != 0) hash ^= Automation.GetHashCode();
      if (PipelineUid.Length != 0) hash ^= PipelineUid.GetHashCode();
      if (Type != global::Google.Cloud.Deploy.V1.Type.Unspecified) hash ^= Type.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Message.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Message);
      }
      if (Automation.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Automation);
      }
      if (PipelineUid.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(PipelineUid);
      }
      if (Type != global::Google.Cloud.Deploy.V1.Type.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Type);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Message.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Message);
      }
      if (Automation.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Automation);
      }
      if (PipelineUid.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(PipelineUid);
      }
      if (Type != global::Google.Cloud.Deploy.V1.Type.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Type);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Message.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      if (Automation.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Automation);
      }
      if (PipelineUid.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PipelineUid);
      }
      if (Type != global::Google.Cloud.Deploy.V1.Type.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AutomationEvent other) {
      if (other == null) {
        return;
      }
      if (other.Message.Length != 0) {
        Message = other.Message;
      }
      if (other.Automation.Length != 0) {
        Automation = other.Automation;
      }
      if (other.PipelineUid.Length != 0) {
        PipelineUid = other.PipelineUid;
      }
      if (other.Type != global::Google.Cloud.Deploy.V1.Type.Unspecified) {
        Type = other.Type;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Message = input.ReadString();
            break;
          }
          case 18: {
            Automation = input.ReadString();
            break;
          }
          case 26: {
            PipelineUid = input.ReadString();
            break;
          }
          case 32: {
            Type = (global::Google.Cloud.Deploy.V1.Type) input.ReadEnum();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Message = input.ReadString();
            break;
          }
          case 18: {
            Automation = input.ReadString();
            break;
          }
          case 26: {
            PipelineUid = input.ReadString();
            break;
          }
          case 32: {
            Type = (global::Google.Cloud.Deploy.V1.Type) input.ReadEnum();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
