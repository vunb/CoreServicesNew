﻿using System;
using System.Collections.Generic;
using Vietbait.Lablink.Utilities;

namespace Vietbait.Lablink.Devices.Immunology
{
    public class VersaCellOrderRecord : OrderRecord
    {
        #region attributries

        private FieldOfRecord _prvActionCode;
        private FieldOfRecord _prvPriority;
        private FieldOfRecord _prvRecordType;
        private FieldOfRecord _prvSeqNumber;
        private FieldOfRecord _prvSpecId;
        private FieldOfRecord _prvSpecimenType;
        private string[] _prvTestId;
        private FieldOfRecord _prvTestIdString;

        #endregion

        public VersaCellOrderRecord()
        {
            RecordType = "O";
            RecordDelimiter = DeviceHelper.CR;
            FieldDelimiter = '|';
            RepeatDelimiter = '\\';
            ComponentDelimiter = '^';
            EscDelimiter = '&';
            _prvSeqNumber.PubFieldData = "1";
            _prvSeqNumber.PubFieldIndex = 2;
            _prvSpecId.PubFieldData = "";
            _prvSpecId.PubFieldIndex = 3;
            _prvTestIdString.PubFieldData = "";
            _prvTestIdString.PubFieldIndex = 5;
            _prvPriority.PubFieldData = "R";
            _prvPriority.PubFieldIndex = 6;
            _prvActionCode.PubFieldData = "";
            _prvActionCode.PubFieldIndex = 12;
            _prvSpecimenType.PubFieldData = "1";
            _prvSpecimenType.PubFieldIndex = 16;
            _prvRecordType.PubFieldData = "";
            _prvRecordType.PubFieldIndex = 26;
        }

        public VersaCellOrderRecord(string[] sInput) : this()
        {
            PrvParseData(sInput);
        }

        public override FieldOfRecord SegNumber
        {
            get { return _prvSeqNumber; }
            set { _prvSeqNumber = value; }
        }

        public override FieldOfRecord SpecId
        {
            get { return _prvSpecId; }
            set { _prvSpecId = value; }
        }

        public override FieldOfRecord TestIdString
        {
            get { return _prvTestIdString; }
            set { _prvTestIdString = value; }
        }

        public FieldOfRecord SpecimenType
        {
            get { return _prvSpecimenType; }
            set { _prvSpecimenType = value; }
        }

        public string Barcode { get; set; }

        public override string[] TestId
        {
            get { return _prvTestId; }
            set { _prvTestId = value; }
        }

        public override sealed char FieldDelimiter { get; set; }

        public override sealed char RepeatDelimiter { get; set; }

        public override sealed char ComponentDelimiter { get; set; }

        public override sealed char EscDelimiter { get; set; }

        public override sealed string RecordType { get; set; }

        public override sealed char RecordDelimiter { get; set; }

        ~VersaCellOrderRecord()
        {
        }

        private bool PrvParseData(string[] sInput)
        {
            if (sInput[0] != RecordType)
            {
                return false;
            }
            _prvSeqNumber.PubFieldData = sInput[_prvSeqNumber.PubFieldIndex - 1];
            _prvSpecId.PubFieldData = sInput[_prvSpecId.PubFieldIndex - 1];

            string[] arrString = _prvSpecId.PubFieldData.Split(ComponentDelimiter);
            Barcode = arrString[0];
            _prvTestIdString.PubFieldData = sInput[_prvTestIdString.PubFieldIndex - 1];
            string[] sTemp = _prvTestIdString.PubFieldData.Split(RepeatDelimiter);
            byte i = 0;
            Array.Resize(ref _prvTestId, sTemp.Length);
            foreach (string s in sTemp)
            {
                string[] ss = s.Split(ComponentDelimiter);
                _prvTestId[i++] = ss[3];
            }
            return true;
        }


        public override bool ParseData(string[] sInput)
        {
            throw new NotImplementedException();
        }

        public override string CreateData()
        {
            var sTmpArray = new string[26];
            sTmpArray[0] = RecordType;
            sTmpArray[_prvSeqNumber.PubFieldIndex - 1] = _prvSeqNumber.PubFieldData;
            sTmpArray[_prvSpecId.PubFieldIndex - 1] = _prvSpecId.PubFieldData;
            sTmpArray[_prvTestIdString.PubFieldIndex - 1] = _prvTestIdString.PubFieldData;
            sTmpArray[_prvPriority.PubFieldIndex - 1] = _prvPriority.PubFieldData;
            sTmpArray[_prvActionCode.PubFieldIndex - 1] = _prvActionCode.PubFieldData;
            sTmpArray[_prvSpecimenType.PubFieldIndex - 1] = _prvSpecimenType.PubFieldData;
            sTmpArray[_prvRecordType.PubFieldIndex - 1] = _prvRecordType.PubFieldData;
            string sTmp = string.Join(FieldDelimiter.ToString(), sTmpArray);
            sTmp = string.Concat(sTmp, RecordDelimiter);
            return sTmp;
        }

        public string CreateData(string barcode, List<string> requestList)
        {
            _prvSpecId.PubFieldData = barcode;
            _prvRecordType.PubFieldData = @"O\Q";
            foreach (String s in requestList)
                _prvTestIdString.PubFieldData = String.Concat(_prvTestIdString.PubFieldData, @"^^^", s, @"\");
            _prvTestIdString.PubFieldData =
                _prvTestIdString.PubFieldData.Remove(_prvTestIdString.PubFieldData.Length - 1, 1);

            return CreateData();
        }
    }
}