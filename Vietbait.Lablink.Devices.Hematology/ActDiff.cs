﻿using System;
using System.Collections.Generic;
using Vietbait.Lablink.TestResult;
using Vietbait.Lablink.Utilities;

namespace Vietbait.Lablink.Devices.Hematology
{
    internal class ActDiff : Rs232AstmDevice
    {
        /// <summary>
        ///     Xử lý sau kkhi nhận được dữ liệu
        /// </summary>
        public override void ProcessData()
        {
            try
            {
                Log.Trace("Begin Process Data");
                //Lưu lại Data
                Log.Trace(string.Format("Raw Data:\n{0}", StringData));
                TestResult.TestDate = string.Empty;

                //Lấy về dữ liệu của các bệnh nhân
                IEnumerable<string> arrPatients = SeparatorData(StringData);

                //Duyệt qua mảng xử lý dữ liệu của từng bệnh nhân
                foreach (string patient in arrPatients)
                {
                    foreach (string record in patient.Split(DeviceHelper.CR))
                    {
                        string[] temp;
                        if (record.StartsWith("O"))
                        {
                            temp = record.Split('|');
                            //Lấy barcode xét nghiệm
                            try
                            {
                                string strTempbarcode = temp[2].Trim();
                                try
                                {
                                    strTempbarcode = Convert.ToInt32(strTempbarcode).ToString();
                                }
                                catch (Exception)
                                {
                                }
                                if (strTempbarcode.Contains("^"))
                                    TestResult.Barcode = strTempbarcode.Split('^')[0];
                                else
                                    TestResult.Barcode = strTempbarcode == "" ? "0000" : strTempbarcode;
                            }
                            catch (Exception)
                            {
                                TestResult.Barcode = "0000";
                            }
                        }
                            //lấy kq ra
                        else if (record.StartsWith("R"))
                        {
                            try
                            {
                                temp = record.Split('|');
                                if (Convert.ToInt32(temp[1]) <= 18)
                                {
                                    //Lấy về ngày tháng làm xét nghiệm
                                    if (String.IsNullOrEmpty(TestResult.TestDate))
                                    {
                                        string tempDate = temp[12];
                                        TestResult.TestDate = string.Format("{0}/{1}/{2}", tempDate.Substring(6, 2),
                                            tempDate.Substring(4, 2),
                                            tempDate.Substring(0, 4));
                                    }
                                    string strTestName = temp[2].Replace("!", "").Trim();
                                    string strTestValue =
                                        temp[3].ToUpper()
                                            .Replace("X", "")
                                            .Replace("!", "")
                                            .Replace("*", "")
                                            .Replace("H", "")
                                            .Replace("L", "")
                                            .Replace("+", "")
                                            .Trim();
                                    string strTestUnit = temp[4].Replace("x", "");
                                    AddResult(new ResultItem(strTestName, strTestValue, strTestUnit));
                                }
                            }
                            catch (Exception ex)
                            {
                            }
                        }
                    }

                    Log.Debug("Begin Import Result");
                    Log.Debug(ImportResults() ? "Finish Import Result" : "Finish Import Error");
                }
                Log.Trace("Finish Process Data {0}", DeviceHelper.CRLF);
            }
            catch (Exception ex)
            {
                // throw ex;
                Log.Error("Error While Process Data: Error String = {0}", ex.ToString());
            }
            finally
            {
                ClearData();
            }
        }

        private IEnumerable<string> SeparatorData(string stringData)
        {
            try
            {
                //Bỏ tất cả các ký tự cho đến khi gặp ký tự "P" đầu tiên
                stringData =
                    stringData.Substring(stringData.IndexOf(DeviceHelper.CR + "P|", StringComparison.Ordinal) + 1);

                //Ngắt chuỗi theo ký tự CR
                string[] arrStringData = stringData.Split(DeviceHelper.CR);

                //Biến để lưu tất cả các chuỗi kết quả.
                //Mỗi phần tử của chuỗi là một kết quả của bệnh nhân gồm các record P,O,R,C.....
                var allResult = new string[] {};

                //Biến lưu Index
                int id = 0;

                foreach (string line in arrStringData)
                {
                    if (line.StartsWith("P"))
                    {
                        id++;
                        Array.Resize(ref allResult, id);
                    }
                    allResult[id - 1] = allResult[id - 1] + line + DeviceHelper.CR;
                }

                return allResult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}