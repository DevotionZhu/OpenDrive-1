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


namespace VehStatus.DefPosition
{
    /// <summary>
    /// Represents schema type 'ElevationConfidence' (ENUMERATED)
    /// </summary>
    [System.Serializable]
    public enum ElevationConfidence
    {
        Unavailable = 0,
        Elev50000 = 1,
        Elev20000 = 2,
        Elev10000 = 3,
        Elev05000 = 4,
        Elev02000 = 5,
        Elev01000 = 6,
        Elev00500 = 7,
        Elev00200 = 8,
        Elev00100 = 9,
        Elev00050 = 10,
        Elev00020 = 11,
        Elev00010 = 12,
        Elev00005 = 13,
        Elev00002 = 14,
        Elev00001 = 15
    }
}
