/*************************************************************/
/* Copyright (C) 2020 OSS Nokalva, Inc.  All rights reserved.*/
/*************************************************************/

/* THIS FILE IS PROPRIETARY MATERIAL OF OSS NOKALVA, INC.
 * AND MAY BE USED ONLY BY DIRECT LICENSEES OF OSS NOKALVA, INC.
 * THIS FILE MAY NOT BE DISTRIBUTED.
 * THIS COPYRIGHT STATEMENT MAY NOT BE REMOVED. */

/* Generated for: tongji (Trial), License 80149Z 80149Z. */
/* Abstract syntax: VehStatus */
/* Created: Thu Jan 16 15:47:39 2020 */
/* ASN.1/C# Compiler version: 4.7 */
/* ASN.1 compiler options and file names specified:
 * -uper -root -noSampleCode -messageFormat msvc -allow universaltags
 * F:/OneDrive - ͬ�ô�ѧ/MAGIC/��·Эͬ/�˳��ڻ�/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/BSM.asn
 * F:/OneDrive - ͬ�ô�ѧ/MAGIC/��·Эͬ/�˳��ڻ�/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/DefAcceleration.asn
 * F:/OneDrive - ͬ�ô�ѧ/MAGIC/��·Эͬ/�˳��ڻ�/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/DefMotion.asn
 * F:/OneDrive - ͬ�ô�ѧ/MAGIC/��·Эͬ/�˳��ڻ�/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/DefPosition.asn
 * F:/OneDrive - ͬ�ô�ѧ/MAGIC/��·Эͬ/�˳��ڻ�/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/DefPositionOffset.asn
 * F:/OneDrive - ͬ�ô�ѧ/MAGIC/��·Эͬ/�˳��ڻ�/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/DefTime.asn
 * F:/OneDrive - ͬ�ô�ѧ/MAGIC/��·Эͬ/�˳��ڻ�/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/Map.asn
 * F:/OneDrive - ͬ�ô�ѧ/MAGIC/��·Эͬ/�˳��ڻ�/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/MapLane.asn
 * F:/OneDrive - ͬ�ô�ѧ/MAGIC/��·Эͬ/�˳��ڻ�/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/MapLink.asn
 * F:/OneDrive - ͬ�ô�ѧ/MAGIC/��·Эͬ/�˳��ڻ�/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/MapNode.asn
 * F:/OneDrive - ͬ�ô�ѧ/MAGIC/��·Эͬ/�˳��ڻ�/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/MapPoint.asn
 * F:/OneDrive - ͬ�ô�ѧ/MAGIC/��·Эͬ/�˳��ڻ�/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/MapSpeedLimit.asn
 * F:/OneDrive - ͬ�ô�ѧ/MAGIC/��·Эͬ/�˳��ڻ�/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/MsgFrame.asn
 * F:/OneDrive - ͬ�ô�ѧ/MAGIC/��·Эͬ/�˳��ڻ�/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/RSI.asn
 * F:/OneDrive - ͬ�ô�ѧ/MAGIC/��·Эͬ/�˳��ڻ�/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/RSM.asn
 * F:/OneDrive - ͬ�ô�ѧ/MAGIC/��·Эͬ/�˳��ڻ�/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/SignalPhaseAndTiming.asn
 * F:/OneDrive - ͬ�ô�ѧ/MAGIC/��·Эͬ/�˳��ڻ�/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/SPATIntersectionState.asn
 * F:/OneDrive - ͬ�ô�ѧ/MAGIC/��·Эͬ/�˳��ڻ�/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/VehBrake.asn
 * F:/OneDrive - ͬ�ô�ѧ/MAGIC/��·Эͬ/�˳��ڻ�/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/VehClass.asn
 * F:/OneDrive - ͬ�ô�ѧ/MAGIC/��·Эͬ/�˳��ڻ�/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/VehSafetyExt.asn
 * F:/OneDrive - ͬ�ô�ѧ/MAGIC/��·Эͬ/�˳��ڻ�/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/VehSize.asn
 * F:/OneDrive - ͬ�ô�ѧ/MAGIC/��·Эͬ/�˳��ڻ�/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/VehStatus.asn
 */


namespace VehStatus.MapNode
{
    /// <summary>
    /// Represents schema type 'NodeReferenceID' (SEQUENCE)
    /// </summary>
    [System.Serializable]
    public partial class NodeReferenceID : Oss.Asn1.BaseType
    {
        /// <summary>Field 'region'</summary>
        public int? Region { get; set; }
        /// <summary>Field 'id'</summary>
        public int Id { get; set; }

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="right">The object to compare with this object. </param>
        /// <returns>true if the specified object is equal to the current object; otherwise, false.</returns>
        public override bool Equals(object right)
        {
            if (right == null)
                return false;
            if (object.ReferenceEquals(this, right))
                return true;
            if (this.GetType() != right.GetType())
                return false;
            NodeReferenceID that = right as NodeReferenceID;
            if (Region != null) {
                if (Region != that.Region)
                    return false;
            } else if (that.Region != null)
                return false;
            if (Id != that.Id)
                return false;
            return true;
        }

        /// <summary>
        /// Serves as a hash function for a particular type.
        /// </summary>
        /// <returns>A hash code for the current object.</returns>
        public override int GetHashCode()
        {
            int hash = GetType().GetHashCode();
            if (Region != null)
                hash ^= Region.GetHashCode();
            hash ^= Id.GetHashCode();
            return hash;
        }

        /// <summary>
        /// Returns the name of the ASN.1 schema type represented by this class.
        /// </summary>
        /// <returns>the string containing the name of the ASN.1 schema type.</returns>
        public override string GetAsn1TypeName()
        {
            return "NodeReferenceID";
        }

        /// <summary>
        /// Asserts the validity of this object`s ASN.1 data.
        /// </summary>
        /// <exception cref="Oss.Asn1.Asn1InvalidDataException">Thrown if the instance contains invalid data.</exception>
        public override void Validate()
        {
            try {
                try {
                    if (this.Region != null) {
                        if (this.Region.Value < 0)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                        if (this.Region.Value > 65535)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Region.Value", "int", "region", "RoadRegulatorID", false); throw;
                }
                try {
                    if (this.Id < 0)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                    if (this.Id > 65535)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Id", "int", "id", "NodeID", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "NodeReferenceID", null, "NodeReferenceID", false); throw;
            }
        }

        /// <summary>
        /// Creates the deep copy of this object.
        /// </summary>
        /// <returns>A new object that is a deep copy of this instance.</returns>
        public override object Copy()
        {
            NodeReferenceID obj0 = new NodeReferenceID();
            {
                obj0.Region = this.Region;
            }
            {
                obj0.Id = this.Id;
            }
            return obj0;
        }

        protected override void PrintAsn1ValueNotation(Oss.Asn1.Internal.ValueNotationHelper prt)
        {
            try
            {
                bool first0 = true;

                prt.BeginConstructedValue();
                {
                    int? data1 = this.Region;

                    if (data1 != null) {
                        prt.WriteLine();
                        first0 = false;
                        prt.Write("region ");
                        prt.Write(data1.Value);
                    }
                }
                {
                    prt.WriteLine(first0 ? "" : ",");
                    prt.Write("id ");
                    prt.Write(this.Id);
                }
                prt.EndConstructedValue();
            }
            catch (System.Exception)
            {
                prt.ResetIndent();
                throw;
            }
        }

        protected override void EncodePer(Oss.Asn1.Internal.PerEncoder enc)
        {
            try {
                byte[] optMask0 = new byte[1];

                if (this.Region != null)
                    optMask0[0] |= (byte)(0x80 >> 0);
                enc.Output.WriteBits(optMask0, 0, 1);
                try {
                    if (this.Region != null)
                    {
                        if (enc.BitCount(this.Region.Value - 0) > 16 || this.Region.Value < 0)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange, ", value = " + this.Region.Value);
                        enc.EncodeConstrainedInteger((this.Region.Value - (0)), 16);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Region.Value", "int", "region", "RoadRegulatorID", false); throw;
                }
                try {
                    if (enc.BitCount(this.Id - 0) > 16 || this.Id < 0)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange, ", value = " + this.Id);
                    enc.EncodeConstrainedInteger((this.Id - (0)), 16);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Id", "int", "id", "NodeID", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "NodeReferenceID", null, "NodeReferenceID", false); throw;
            }
        }

        protected override void DecodePer(Oss.Asn1.Internal.PerDecoder dec)
        {
            try {
                byte[] optMask0 = new byte[1];

                dec.Input.ReadBits(optMask0, 1);
                if ((optMask0[0] & (0x80 >> 0)) != 0)
                {
                    try {
                        this.Region = dec.DecodeConstrainedInteger(16, 0);
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "Region", "int", "region", "RoadRegulatorID", false); throw;
                    }
                }
                else
                {
                    this.Region = null;
                }
                try {
                    this.Id = dec.DecodeConstrainedInteger(16, 0);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Id", "int", "id", "NodeID", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "NodeReferenceID", null, "NodeReferenceID", false); throw;
            }
        }
    }
}
