﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using EServ.Data;
using EServ.Shared;
using EServ.Interface;

namespace IPos.Order
{
    public class Order : IModule
    {
        DateTime first;
        public static Result F_Error(Result res)
        {
            int DdIdErrorNo = -2147467259;

            if (res.ResultNo == DdIdErrorNo)
            {
                if (res.ResultDesc.IndexOf("ORA-00001") != -1)
                {
                    res.ResultNo = 9110039;
                    res.ResultDesc = "Бичлэг давхардаж байна. {ID дугаар эсвэл Эрэмбийн дугаар}";
                }
            }
            return res;
        }
        public override Result Invoke(ClientInfo ci, RequestInfo ri, DbConnections db, ref Log lg)
        {
            Result res = new Result();
            try
            {
                first = DateTime.Now;
                switch (ri.FunctionNo)
                {
                    #region[Захиалгын үндсэн бүртгэл]
                    case 130101:	                //	Захиалгын үндсэн бүртгэл жагсаалт мэдээлэл авах
                        res = Txn130101(ci, ri, db, ref lg);
                        break;
                    case 130102:	                //  Захиалгын үндсэн бүртгэл дэлгэрэнгүй мэдээлэл авах
                        res = Txn130102(ci, ri, db, ref lg);
                        break;
                    case 130103:	                //	Захиалгын үндсэн бүртгэл нэмэх
                        res = Txn130103(ci, ri, db, ref lg);
                        break;
                    case 130104:	                //	Захиалгын үндсэн бүртгэл засах
                        res = Txn130104(ci, ri, db, ref lg);
                        break;
                    case 130105:	                //	Захиалгын үндсэн бүртгэл устгах
                        res = Txn130105(ci, ri, db, ref lg);
                        break;
                    #endregion
                    #region[Захиалга өгсөн үйлчлүүлэгчид]
                    case 130106:	                //
                        res = Txn130106(ci, ri, db, ref lg);
                        break;
                    case 130107:	                //
                        res = Txn130107(ci, ri, db, ref lg);
                        break;
                    case 130108:	                //
                        res = Txn130108(ci, ri, db, ref lg);
                        break;
                    case 130109:	                //
                        res = Txn130109(ci, ri, db, ref lg);
                        break;
                    case 130110:	                //
                        res = Txn130110(ci, ri, db, ref lg);
                        break;
                    #endregion
                    #region[Захиалга доторх багц үйлчилгээний бүлэг]
                    case 130111:	                //	Захиалга доторх багц үйлчилгээний бүлэг жагсаалт мэдээлэл авах
                        res = Txn130111(ci, ri, db, ref lg);
                        break;
                    case 130112:	                //  Захиалга доторх багц үйлчилгээний бүлэг дэлгэрэнгүй мэдээлэл авах
                        res = Txn130112(ci, ri, db, ref lg);
                        break;
                    case 130113:	                //	Захиалга доторх багц үйлчилгээний бүлэг нэмэх
                        res = Txn130113(ci, ri, db, ref lg);
                        break;
                    case 130114:	                //	Захиалга доторх багц үйлчилгээний бүлэг засах
                        res = Txn130114(ci, ri, db, ref lg);
                        break;
                    case 130115:	                //	Захиалга доторх багц үйлчилгээний бүлэг устгах
                        res = Txn130115(ci, ri, db, ref lg);
                        break;
                    #endregion
                    #region[Захиалгын багц дах бүтээгдэхүүний бүртгэл]
                    case 130116:	                //	Захиалгын багц дахь бүтээгдэхүүний бүртгэл жагсаалт мэдээлэл авах
                        res = Txn130116(ci, ri, db, ref lg);
                        break;
                    case 130117:	                //  Захиалгын багц дахь бүтээгдэхүүний бүртгэл дэлгэрэнгүй мэдээлэл авах
                        res = Txn130117(ci, ri, db, ref lg);
                        break;
                    case 130118:	                //	Захиалгын багц дахь бүтээгдэхүүн нэмэх
                        res = Txn130118(ci, ri, db, ref lg);
                        break;
                    case 130119:	                //	Захиалгын багц дахь бүтээгдэхүүн засах
                        res = Txn130116(ci, ri, db, ref lg);
                        break;
                    case 130120:	                //	Захиалгын багц дахь бүтээгдэхүүн устгах
                        res = Txn130120(ci, ri, db, ref lg);
                        break;
                    #endregion
                    #region[Захиалгын хүснэгт бүртгэл]
                    case 130121:	                //	
                        res = Txn130121(ci, ri, db, ref lg);
                        break;
                    case 130123:	                //	
                        res = Txn130123(ci, ri, db, ref lg);
                        break;
                    case 130124:	                //	
                        res = Txn130124(ci, ri, db, ref lg);
                        break;
                    case 130125:	                //устгах
                        res = Txn130125(ci, ri, db, ref lg);
                        break;
                    #endregion
                    #region[Захиалгын баталгаажуулах]
                    case 130126:	                //	
                        res = Txn130126(ci, ri, db, ref lg);
                        break;
                    #endregion
                    #region[Захиалга цуцлах]
                    case 130127:	                //	
                        res = Txn130127(ci, ri, db, ref lg);
                        break;
                    #endregion
                    #region[Захиалга сунгах]
                    case 130128:	                //	
                        res = Txn130128(ci, ri, db, ref lg);
                        break;
                    #endregion
                    #region[Захиалгад орсон хуваарьтай үйлчилгээний жагсаалт авах]
                    case 130500:	                //	
                        res = Txn130500(ci, ri, db, ref lg);
                        break;
                    #endregion
                    #region[Захиалгын хуваарьт орсон үйлчилгээнүүдийн жагссалт авах]
                    case 130501:	                //	
                        res = Txn130501(ci, ri, db, ref lg);
                        break;
                    #endregion
                    default:
                        res.ResultNo = 9110009;
                        res.ResultDesc = "Функц тодорхойлогдоогүй байна";
                        break;
                }
                return res;
            }
            catch (Exception ex)
            {
                res.ResultNo = 9110002;
                res.ResultDesc = "Програм руу нэвтрэхэд алдаа гарлаа" + ex.Message;

                EServ.Shared.Static.WriteToLogFile("Error.log", ex.Message + ex.Source + ex.StackTrace);

                return res;
            }
            finally
            {
                string ResultDesk = "OK";
                if (res.ResultNo != 0)
                {
                    ResultDesk = res.ResultDesc;
                }
                DateTime second = DateTime.Now;
                ISM.Lib.Static.WriteToLogFile("IPos.Contract", "\r\n<<Start:" + Static.ToStr(first) + ">>\r\n UserNo:" + Static.ToStr(ri.UserNo) + "\r\n Description:" + Static.ToStr(lg.item.Desc) + "\r\n ResultNo:" + Static.ToStr(res.ResultNo) + "\r\n ResultDescription:" + ResultDesk + "\r\n<<End " + Static.ToStr(second) + ">>");
            }
        }
        #region [Захиалгын бүртгэл]
        public Result Txn130101(ClientInfo ci, RequestInfo ri, DbConnections db, ref Log lg)
        {
            Result res = new Result();
            try
            {
                res = IPos.DB.Main.DB204101(db, 1, 1, null);
                return res;
            }
            catch (Exception ex)
            {
                res.ResultNo = 9110002;
                res.ResultDesc = "Програм руу нэвтрэхэд алдаа гарлаа" + ex.Message;

                EServ.Shared.Static.WriteToLogFile("Error.log", ex.Message + ex.Source + ex.StackTrace);

                return res;
            }
            finally
            {
                lg.item.Desc = "Захиалгын үндсэн бүртгэл жагсаалт мэдээлэл авах";
                if (res.ResultNo == 0)
                {
                    lg.AddDetail("ORDERS", "", lg.item.Desc, ri.ReceivedParam[0].ToString());
                }
            }
        }
        public Result Txn130102(ClientInfo ci, RequestInfo ri, DbConnections db, ref Log lg)
        {
            Result res = new Result();
            try
            {
                res = IPos.DB.Main.DB204102(db, Static.ToStr(ri.ReceivedParam[0]));
                return res;
            }
            catch (Exception ex)
            {
                res.ResultNo = 9110002;
                res.ResultDesc = "Програм руу нэвтрэхэд алдаа гарлаа" + ex.Message;

                EServ.Shared.Static.WriteToLogFile("Error.log", ex.Message + ex.Source + ex.StackTrace);

                return res;
            }
            finally
            {
                lg.item.Desc = "Захиалгын үндсэн бүртгэл дэлгэрэнгүй мэдээлэл авах";
                lg.AddDetail("ORDERS", "ORDERNO", lg.item.Desc, ri.ReceivedParam[0].ToString());
            }
        }
        public Result Txn130103(ClientInfo ci, RequestInfo ri, DbConnections db, ref Log lg)
        {
            Result res = new Result();
            try
            {
                res = IPos.DB.Main.DB204103(db, ri.ReceivedParam);
                return res;
            }
            catch (Exception ex)
            {
                res.ResultNo = 9110002;
                res.ResultDesc = "Програм руу нэвтрэхэд алдаа гарлаа" + ex.Message;

                EServ.Shared.Static.WriteToLogFile("Error.log", ex.Message + ex.Source + ex.StackTrace);

                return res;
            }
            finally
            {
                lg.item.Desc = "Захиалгын үндсэн бүртгэл шинээр нэмэх";
                if (res.ResultNo == 0)
                {

                }
            }
        }
        public Result Txn130104(ClientInfo ci, RequestInfo ri, DbConnections db, ref Log lg)
        {
            Result res = new Result();
            try
            {
                res = IPos.DB.Main.DB204104(db, ri.ReceivedParam);
                return res;
            }
            catch (Exception ex)
            {
                res.ResultNo = 9110002;
                res.ResultDesc = "Програм руу нэвтрэхэд алдаа гарлаа" + ex.Message;

                EServ.Shared.Static.WriteToLogFile("Error.log", ex.Message + ex.Source + ex.StackTrace);

                return res;
            }
            finally
            {
                lg.item.Desc = "Захиалгын үндсэн бүртгэл засварлах";
                if (res.ResultNo == 0)
                {

                }
            }
        }
        public Result Txn130105(ClientInfo ci, RequestInfo ri, DbConnections db, ref Log lg)
        {
            Result res = new Result();
            try
            {
                res = IPos.DB.Main.DB204105(db, Static.ToStr(ri.ReceivedParam[0]));
                return res;
            }
            catch (Exception ex)
            {
                res.ResultNo = 9110002;
                res.ResultDesc = "Програм руу нэвтрэхэд алдаа гарлаа" + ex.Message;

                EServ.Shared.Static.WriteToLogFile("Error.log", ex.Message + ex.Source + ex.StackTrace);

                return res;
            }
            finally
            {
                lg.item.Desc = "Захиалгын үндсэн бүртгэл устгах";
            }
        }
        #endregion
        #region [Захиалгад орсон үйлчлүүлэгч]
        public Result Txn130106(ClientInfo ci, RequestInfo ri, DbConnections db, ref Log lg)
        {
            Result res = new Result();
            try
            {
                res = IPos.DB.Main.DB204106(db, Static.ToStr(ri.ReceivedParam[0]));
                return res;
            }
            catch (Exception ex)
            {
                res.ResultNo = 9110002;
                res.ResultDesc = "Програм руу нэвтрэхэд алдаа гарлаа" + ex.Message;

                EServ.Shared.Static.WriteToLogFile("Error.log", ex.Message + ex.Source + ex.StackTrace);

                return res;
            }
            finally
            {
                lg.item.Desc = "Захиалгад орсон үйлчлүүлэгчийн бүртгэл жагсаалт мэдээлэл авах";
                if (res.ResultNo == 0)
                {
                    lg.AddDetail("ORDERPERSON", "", lg.item.Desc, ri.ReceivedParam[0].ToString());
                }
            }
        }
        public Result Txn130107(ClientInfo ci, RequestInfo ri, DbConnections db, ref Log lg)
        {
            Result res = new Result();
            try
            {
                res = IPos.DB.Main.DB204107(db, Static.ToStr(ri.ReceivedParam[0]), Static.ToLong(ri.ReceivedParam[1]));
                return res;
            }
            catch (Exception ex)
            {
                res.ResultNo = 9110002;
                res.ResultDesc = "Програм руу нэвтрэхэд алдаа гарлаа" + ex.Message;

                EServ.Shared.Static.WriteToLogFile("Error.log", ex.Message + ex.Source + ex.StackTrace);

                return res;
            }
            finally
            {
                lg.item.Desc = "Захиалгад орсон үйлчлүүлэгчийн бүртгэл дэлгэрэнгүй мэдээлэл авах";
                lg.AddDetail("ORDERPERSON", "ORDERNO", lg.item.Desc, ri.ReceivedParam[0].ToString());
                lg.AddDetail("ORDERPERSON", "CUSTNO", lg.item.Desc, ri.ReceivedParam[0].ToString());
            }
        }
        public Result Txn130108(ClientInfo ci, RequestInfo ri, DbConnections db, ref Log lg)
        {
            Result res = new Result();
            try
            {
                res = IPos.DB.Main.DB204108(db, ri.ReceivedParam);
                return res;
            }
            catch (Exception ex)
            {
                res.ResultNo = 9110002;
                res.ResultDesc = "Програм руу нэвтрэхэд алдаа гарлаа" + ex.Message;

                EServ.Shared.Static.WriteToLogFile("Error.log", ex.Message + ex.Source + ex.StackTrace);

                return res;
            }
            finally
            {
                lg.item.Desc = "Захиалгад орсон үйлчлүүлэгчийн бүртгэл шинээр нэмэх";
                if (res.ResultNo == 0)
                {

                }
            }
        }
        public Result Txn130109(ClientInfo ci, RequestInfo ri, DbConnections db, ref Log lg)
        {
            Result res = new Result();
            try
            {
                res = IPos.DB.Main.DB204109(db, Static.ToStr(ri.ReceivedParam[0]), Static.ToLong(ri.ReceivedParam[1]), Static.ToLong(ri.ReceivedParam[2]));
                return res;
            }
            catch (Exception ex)
            {
                res.ResultNo = 9110002;
                res.ResultDesc = "Програм руу нэвтрэхэд алдаа гарлаа" + ex.Message;

                EServ.Shared.Static.WriteToLogFile("Error.log", ex.Message + ex.Source + ex.StackTrace);

                return res;
            }
            finally
            {
                lg.item.Desc = "Захиалгад орсон үйлчлүүлэгчийн бүртгэл засварлах";
                if (res.ResultNo == 0)
                {
                    lg.AddDetail("ORDERPERSON", "ORDERNO", lg.item.Desc, ri.ReceivedParam[0].ToString());
                    lg.AddDetail("ORDERPERSON", "CUSTNO", ri.ReceivedParam[1].ToString(), ri.ReceivedParam[2].ToString());
                }
            }
        }
        public Result Txn130110(ClientInfo ci, RequestInfo ri, DbConnections db, ref Log lg)
        {
            Result res = new Result();
            try
            {
                res = IPos.DB.Main.DB204110(db, Static.ToStr(ri.ReceivedParam[0]), Static.ToStr(ri.ReceivedParam[1]));
                return res;
            }
            catch (Exception ex)
            {
                res.ResultNo = 9110002;
                res.ResultDesc = "Програм руу нэвтрэхэд алдаа гарлаа" + ex.Message;

                EServ.Shared.Static.WriteToLogFile("Error.log", ex.Message + ex.Source + ex.StackTrace);

                return res;
            }
            finally
            {
                lg.item.Desc = "Захиалгад орсон үйлчлүүлэгчийн бүртгэл устгах";
                lg.AddDetail("ORDERPERSON", "ORDERNO", lg.item.Desc, ri.ReceivedParam[0].ToString());
                lg.AddDetail("ORDERPERSON", "CUSTNO", lg.item.Desc, ri.ReceivedParam[0].ToString());
            }
        }
        #endregion
        #region [Захиалга доторх багц үйлчилгээний бүлэг]
        public Result Txn130111(ClientInfo ci, RequestInfo ri, DbConnections db, ref Log lg)
        {
            Result res = new Result();
            try
            {
                res = IPos.DB.Main.DB204111(db, Static.ToStr(ri.ReceivedParam[0]));
                return res;
            }
            catch (Exception ex)
            {
                res.ResultNo = 9110002;
                res.ResultDesc = "Програм руу нэвтрэхэд алдаа гарлаа" + ex.Message;

                EServ.Shared.Static.WriteToLogFile("Error.log", ex.Message + ex.Source + ex.StackTrace);

                return res;
            }
            finally
            {
                lg.item.Desc = "Захиалга доторх багц үйлчилгээний бүлэг жагсаалт мэдээлэл авах";
                if (res.ResultNo == 0)
                {
                    lg.AddDetail("ORDERPERSON", "", lg.item.Desc, ri.ReceivedParam[0].ToString());
                }
            }
        }
        public Result Txn130112(ClientInfo ci, RequestInfo ri, DbConnections db, ref Log lg)
        {
            Result res = new Result();
            try
            {
                res = IPos.DB.Main.DB204112(db, Static.ToStr(ri.ReceivedParam[0]), Static.ToLong(ri.ReceivedParam[1]));
                return res;
            }
            catch (Exception ex)
            {
                res.ResultNo = 9110002;
                res.ResultDesc = "Програм руу нэвтрэхэд алдаа гарлаа" + ex.Message;

                EServ.Shared.Static.WriteToLogFile("Error.log", ex.Message + ex.Source + ex.StackTrace);

                return res;
            }
            finally
            {
                lg.item.Desc = "Захиалга доторх багц үйлчилгээний бүлэг дэлгэрэнгүй мэдээлэл авах";
                lg.AddDetail("ORDERPERSON", "ORDERNO", lg.item.Desc, ri.ReceivedParam[0].ToString());
                lg.AddDetail("ORDERPERSON", "CUSTNO", lg.item.Desc, ri.ReceivedParam[0].ToString());
            }
        }
        public Result Txn130113(ClientInfo ci, RequestInfo ri, DbConnections db, ref Log lg)
        {
            Result res = new Result();
            try
            {
                res = IPos.DB.Main.DB204113(db, ri.ReceivedParam);
                return res;
            }
            catch (Exception ex)
            {
                res.ResultNo = 9110002;
                res.ResultDesc = "Програм руу нэвтрэхэд алдаа гарлаа" + ex.Message;

                EServ.Shared.Static.WriteToLogFile("Error.log", ex.Message + ex.Source + ex.StackTrace);

                return res;
            }
            finally
            {
                lg.item.Desc = "Захиалга доторх багц үйлчилгээний бүлэг шинээр нэмэх";
                if (res.ResultNo == 0)
                {

                }
            }
        }
        public Result Txn130114(ClientInfo ci, RequestInfo ri, DbConnections db, ref Log lg)
        {
            Result res = new Result();
            try
            {
                res = IPos.DB.Main.DB204114(db, ri.ReceivedParam);
                return res;
            }
            catch (Exception ex)
            {
                res.ResultNo = 9110002;
                res.ResultDesc = "Програм руу нэвтрэхэд алдаа гарлаа" + ex.Message;

                EServ.Shared.Static.WriteToLogFile("Error.log", ex.Message + ex.Source + ex.StackTrace);

                return res;
            }
            finally
            {
                lg.item.Desc = "Захиалга доторх багц үйлчилгээний бүлэг засварлах";
                if (res.ResultNo == 0)
                {
                    lg.AddDetail("ORDERGROUP", "ORDERNO", lg.item.Desc, ri.ReceivedParam[0].ToString());
                    lg.AddDetail("ORDERGROUP", "GROUPNO", ri.ReceivedParam[1].ToString(), ri.ReceivedParam[2].ToString());
                }
            }
        }
        public Result Txn130115(ClientInfo ci, RequestInfo ri, DbConnections db, ref Log lg)
        {
            Result res = new Result();
            try
            {
                res = IPos.DB.Main.DB204115(db, Static.ToStr(ri.ReceivedParam[0]), Static.ToLong(ri.ReceivedParam[1]));
                return res;
            }
            catch (Exception ex)
            {
                res.ResultNo = 9110002;
                res.ResultDesc = "Програм руу нэвтрэхэд алдаа гарлаа" + ex.Message;

                EServ.Shared.Static.WriteToLogFile("Error.log", ex.Message + ex.Source + ex.StackTrace);

                return res;
            }
            finally
            {
                lg.item.Desc = "Захиалга доторх багц үйлчилгээний бүлэг устгах";
                lg.AddDetail("ORDERGROUP", "ORDERNO", lg.item.Desc, ri.ReceivedParam[0].ToString());
                lg.AddDetail("ORDERGROUP", "GROUPNO", lg.item.Desc, ri.ReceivedParam[0].ToString());
            }
        }
        #endregion
        #region [Захиалгын багц дах бүтээгдэхүүний бүртгэл]
        public Result Txn130116(ClientInfo ci, RequestInfo ri, DbConnections db, ref Log lg)
        {
            Result res = new Result();
            try
            {
                res = IPos.DB.Main.DB204116(db, Static.ToStr(ri.ReceivedParam[0]), Static.ToLong(ri.ReceivedParam[1]));
                return res;
            }
            catch (Exception ex)
            {
                res.ResultNo = 9110002;
                res.ResultDesc = "Програм руу нэвтрэхэд алдаа гарлаа" + ex.Message;

                EServ.Shared.Static.WriteToLogFile("Error.log", ex.Message + ex.Source + ex.StackTrace);

                return res;
            }
            finally
            {
                lg.item.Desc = "Захиалгын багц дахь бүтээгдэхүүний бүртгэл жагсаалт мэдээлэл авах";
                if (res.ResultNo == 0)
                {
                    lg.AddDetail("ORDERPRODUCT", "ORDERNO", lg.item.Desc, ri.ReceivedParam[0].ToString());
                }
            }
        }
        public Result Txn130117(ClientInfo ci, RequestInfo ri, DbConnections db, ref Log lg)
        {
            Result res = new Result();
            try
            {
                res = IPos.DB.Main.DB204117(db, Static.ToStr(ri.ReceivedParam[0]), Static.ToLong(ri.ReceivedParam[1]), Static.ToStr(ri.ReceivedParam[2]), Static.ToInt(ri.ReceivedParam[3]));
                return res;
            }
            catch (Exception ex)
            {
                res.ResultNo = 9110002;
                res.ResultDesc = "Програм руу нэвтрэхэд алдаа гарлаа" + ex.Message;

                EServ.Shared.Static.WriteToLogFile("Error.log", ex.Message + ex.Source + ex.StackTrace);

                return res;
            }
            finally
            {
                lg.item.Desc = "Захиалгын багц дахь бүтээгдэхүүний дэлгэрэнгүй мэдээлэл авах";
                lg.AddDetail("ORDERPRODUCT", "ORDERNO", lg.item.Desc, ri.ReceivedParam[0].ToString());
                lg.AddDetail("ORDERPRODUCT", "GROUPNO", lg.item.Desc, ri.ReceivedParam[0].ToString());
                lg.AddDetail("ORDERPRODUCT", "PRODNO", lg.item.Desc, ri.ReceivedParam[0].ToString());
                lg.AddDetail("ORDERPRODUCT", "PRODTYPE", lg.item.Desc, ri.ReceivedParam[0].ToString());
            }
        }
        public Result Txn130118(ClientInfo ci, RequestInfo ri, DbConnections db, ref Log lg)
        {
            Result res = new Result();
            try
            {
                res = IPos.DB.Main.DB204118(db, ri.ReceivedParam);
                return res;
            }
            catch (Exception ex)
            {
                res.ResultNo = 9110002;
                res.ResultDesc = "Програм руу нэвтрэхэд алдаа гарлаа" + ex.Message;

                EServ.Shared.Static.WriteToLogFile("Error.log", ex.Message + ex.Source + ex.StackTrace);

                return res;
            }
            finally
            {
                lg.item.Desc = "Захиалгын багц дахь бүтээгдэхүүн шинээр нэмэх";
                if (res.ResultNo == 0)
                {

                }
            }
        }
        public Result Txn130119(ClientInfo ci, RequestInfo ri, DbConnections db, ref Log lg)
        {
            Result res = new Result();
            try
            {
                res = IPos.DB.Main.DB204119(db, (object[])ri.ReceivedParam[0], (object[])ri.ReceivedParam[1]);
                return res;
            }
            catch (Exception ex)
            {
                res.ResultNo = 9110002;
                res.ResultDesc = "Програм руу нэвтрэхэд алдаа гарлаа" + ex.Message;

                EServ.Shared.Static.WriteToLogFile("Error.log", ex.Message + ex.Source + ex.StackTrace);

                return res;
            }
            finally
            {
                lg.item.Desc = "Захиалгын багц дахь бүтээгдэхүүн засварлах";
                if (res.ResultNo == 0)
                {

                }
            }
        }
        public Result Txn130120(ClientInfo ci, RequestInfo ri, DbConnections db, ref Log lg)
        {
            Result res = new Result();
            try
            {
                res = IPos.DB.Main.DB204120(db, Static.ToStr(ri.ReceivedParam[0]), Static.ToLong(ri.ReceivedParam[1]), Static.ToStr(ri.ReceivedParam[2]), Static.ToInt(ri.ReceivedParam[3]));
                return res;
            }
            catch (Exception ex)
            {
                res.ResultNo = 9110002;
                res.ResultDesc = "Програм руу нэвтрэхэд алдаа гарлаа" + ex.Message;

                EServ.Shared.Static.WriteToLogFile("Error.log", ex.Message + ex.Source + ex.StackTrace);

                return res;
            }
            finally
            {
                lg.item.Desc = "Захиалга доторх багц дах бүтээгдэхүүн устгах";
                lg.AddDetail("ORDERGROUP", "ORDERNO", lg.item.Desc, ri.ReceivedParam[0].ToString());
                lg.AddDetail("ORDERGROUP", "GROUPNO", lg.item.Desc, ri.ReceivedParam[1].ToString());
                lg.AddDetail("ORDERGROUP", "PRODNO", lg.item.Desc, ri.ReceivedParam[2].ToString());
                lg.AddDetail("ORDERGROUP", "PRODTYPE", lg.item.Desc, ri.ReceivedParam[3].ToString());
            }
        }
        #endregion
        #region[Захиалгын хүснэгт мэдээлэл бүртгэх]
        public Result Txn130121(ClientInfo ci, RequestInfo ri, DbConnections db, ref Log lg)
        {
            Result res = new Result();
            try
            {
                res = IPos.DB.Main.DB204121(db, Static.ToInt(ri.ReceivedParam[0]), Static.ToStr(ri.ReceivedParam[1]), Static.ToDate(ri.ReceivedParam[2]), Static.ToDate(ri.ReceivedParam[3]));
                return res;
            }
            catch (Exception ex)
            {
                res.ResultNo = 9110002;
                res.ResultDesc = "Програм руу нэвтрэхэд алдаа гарлаа" + ex.Message;

                EServ.Shared.Static.WriteToLogFile("Error.log", ex.Message + ex.Source + ex.StackTrace);

                return res;
            }
            finally
            {
                lg.item.Desc = "Захиалгын багц дахь бүтээгдэхүүний бүртгэл жагсаалт мэдээлэл авах";
                if (res.ResultNo == 0)
                {
                    lg.AddDetail("ORDERPRODUCT", "ORDERNO", lg.item.Desc, ri.ReceivedParam[0].ToString());
                }
            }
        }
        public Result Txn130123(ClientInfo ci, RequestInfo ri, DbConnections db, ref Log lg)
        {
            Result res = new Result();
            try
            {

                res = IPos.DB.Main.DB204123(db, ri.ReceivedParam);
                return F_Error(res);
            }
            catch (Exception ex)
            {
                res.ResultNo = 9110002;
                res.ResultDesc = "Програм руу нэвтрэхэд алдаа гарлаа" + ex.Message;

                EServ.Shared.Static.WriteToLogFile("Error.log", ex.Message + ex.Source + ex.StackTrace);

                return res;
            }
            finally
            {
                lg.item.Desc = "Захиалгын багц дахь бүтээгдэхүүн шинээр нэмэх";
                if (res.ResultNo == 0)
                {

                }
            }
        }
        public Result Txn130124(ClientInfo ci, RequestInfo ri, DbConnections db, ref Log lg)
        {
            Result res = new Result();
            try
            {
                res = IPos.DB.Main.DB204124(db, (object[])ri.ReceivedParam[0], (object[])ri.ReceivedParam[1]);
                return F_Error(res);
            }
            catch (Exception ex)
            {
                res.ResultNo = 9110002;
                res.ResultDesc = "Програм руу нэвтрэхэд алдаа гарлаа" + ex.Message;

                EServ.Shared.Static.WriteToLogFile("Error.log", ex.Message + ex.Source + ex.StackTrace);

                return res;
            }
            finally
            {
                lg.item.Desc = "Захиалгын багц дахь бүтээгдэхүүн шинээр нэмэх";
                if (res.ResultNo == 0)
                {

                }
            }
        }
        public Result Txn130125(ClientInfo ci, RequestInfo ri, DbConnections db, ref Log lg)
        {
            Result res = new Result();
            try
            {
                res = IPos.DB.Main.DB204125(db, Static.ToInt(ri.ReceivedParam[0]), Static.ToStr(ri.ReceivedParam[1]), Static.ToLong(ri.ReceivedParam[2]),Static.ToStr(ri.ReceivedParam[3]),Static.ToStr(ri.ReceivedParam[4]),Static.ToDateTime(ri.ReceivedParam[5]));
                return res;
            }
            catch (Exception ex)
            {
                res.ResultNo = 9110002;
                res.ResultDesc = "Програм руу нэвтрэхэд алдаа гарлаа" + ex.Message;

                EServ.Shared.Static.WriteToLogFile("Error.log", ex.Message + ex.Source + ex.StackTrace);

                return res;
            }
            finally
            {
                lg.item.Desc = "Захиалга доторх багц дах бүтээгдэхүүн устгах";
                lg.AddDetail("ORDERGROUP", "ORDERNO", lg.item.Desc, ri.ReceivedParam[0].ToString());
                lg.AddDetail("ORDERGROUP", "GROUPNO", lg.item.Desc, ri.ReceivedParam[1].ToString());
                lg.AddDetail("ORDERGROUP", "PRODNO", lg.item.Desc, ri.ReceivedParam[2].ToString());
                lg.AddDetail("ORDERGROUP", "PRODTYPE", lg.item.Desc, ri.ReceivedParam[3].ToString());
            }
        }
        #endregion
        #region[Захиалга  баталгаажуулах]
        public Result Txn130126(ClientInfo ci, RequestInfo ri, DbConnections db, ref Log lg)
        {
            Result res = new Result();
            try
            {
                res = IPos.DB.Main.DB204126(db, Static.ToStr(ri.ReceivedParam[0]), Static.ToDateTime(ri.ReceivedParam[1]), Static.ToInt(ri.ReceivedParam[2]));
                return res;
            }
            catch (Exception ex)
            {
                res.ResultNo = 9110002;
                res.ResultDesc = "Програм руу нэвтрэхэд алдаа гарлаа" + ex.Message;

                EServ.Shared.Static.WriteToLogFile("Error.log", ex.Message + ex.Source + ex.StackTrace);

                return res;
            }
            finally
            {
                lg.item.Desc = "Захиалгыг баталгаажуулах";
                if (res.ResultNo == 0)
                {
                    lg.AddDetail("ORDER", "ORDERNO", lg.item.Desc, ri.ReceivedParam[0].ToString());
                }
            }
        }
        #endregion
        #region[Захиалга цуцлах]
        public Result Txn130127(ClientInfo ci, RequestInfo ri, DbConnections db, ref Log lg)
        {
            Result res = new Result();
            try
            {

                res = IPos.DB.Main.DB204127(db, Static.ToStr(ri.ReceivedParam[0]), Static.ToDateTime(ri.ReceivedParam[1]), Static.ToInt(ri.ReceivedParam[2]), Static.ToStr(ri.ReceivedParam[3]));
                return res;
            }
            catch (Exception ex)
            {
                res.ResultNo = 9110002;
                res.ResultDesc = "Програм руу нэвтрэхэд алдаа гарлаа" + ex.Message;

                EServ.Shared.Static.WriteToLogFile("Error.log", ex.Message + ex.Source + ex.StackTrace);

                return res;
            }
            finally
            {
                lg.item.Desc = "Захиалгыг цуцлах";
                if (res.ResultNo == 0)
                {
                    lg.AddDetail("ORDER", "ORDERNO", lg.item.Desc, ri.ReceivedParam[0].ToString());
                }
            }
        }
        #endregion
        #region[Захиалга сунгах]
        public Result Txn130128(ClientInfo ci, RequestInfo ri, DbConnections db, ref Log lg)
        {
            Result res = new Result();
            try
            {
                res = IPos.DB.Main.DB204128(db, Static.ToStr(ri.ReceivedParam[0]), Static.ToDate(ri.ReceivedParam[1]), Static.ToInt(ri.ReceivedParam[2]));
                return res;
            }
            catch (Exception ex)
            {
                res.ResultNo = 9110002;
                res.ResultDesc = "Програм руу нэвтрэхэд алдаа гарлаа" + ex.Message;

                EServ.Shared.Static.WriteToLogFile("Error.log", ex.Message + ex.Source + ex.StackTrace);

                return res;
            }
            finally
            {
                lg.item.Desc = "Захиалгыг сунгах";
                if (res.ResultNo == 0)
                {
                    lg.AddDetail("ORDER", "ORDERNO", lg.item.Desc, ri.ReceivedParam[0].ToString());
                    lg.AddDetail("ORDER", "ExpendDate", lg.item.Desc, ri.ReceivedParam[1].ToString());
                }
            }
        }
        #endregion
        #region[Захиалгад орсон хуваарьтай үйлчилгээний жагсаалт авах]
        public Result Txn130500(ClientInfo ci, RequestInfo ri, DbConnections db, ref Log lg)
        {
            Result res = new Result();
            try
            {
                object[] obj=new object[2];
                obj = ri.ReceivedParam;
                string sql = @"select scheduletype from servmain where servid=:1";
                res = db.ExecuteQuery("core", sql, enumCommandType.SELECT, "Txn130500", obj[0]);
                if (res.ResultNo == 0)
                {
                    if (res.Data != null && res.Data.Tables[0].Rows.Count > 0)
                    {
                        sql = @"select 0 as status,prodno,name from orderproduct a
left join servmain b on A.PRODNO=B.SERVID
where a.orderno=:1 and b.isschedule=1 and b.SCHEDULETYPE=:2 and a.prodno<>:3";
                        res = db.ExecuteQuery("core", sql, enumCommandType.SELECT, "Txn130128", obj[1], res.Data.Tables[0].Rows[0]["scheduletype"], obj[0]);
                        return res;
                    }
                }
                else
                {
                    res.ResultNo = 9110002;
                    res.ResultDesc = "Үйлчилгээний бичлэг олдсонгүй";
                    return res;
                }
                return res;
            }
            catch (Exception ex)
            {
                res.ResultNo = 9110002;
                res.ResultDesc = "Програм руу нэвтрэхэд алдаа гарлаа" + ex.Message;

                EServ.Shared.Static.WriteToLogFile("Error.log", ex.Message + ex.Source + ex.StackTrace);

                return res;
            }
            finally
            {
                lg.item.Desc = "Захиалгад орсон хуваарьтай үйлчилгээний жагсаалт авах";
            }
        }
        #endregion
        #region[Захиалгын хуваарьт орсон үйлчилгээнүүдийн жагссалт авах]
        public Result Txn130501(ClientInfo ci, RequestInfo ri, DbConnections db, ref Log lg)
        {
            Result res = new Result();
            try
            {
                string sql = @"select a.prodno,b.name from prodtimesheet a
left join servmain b on b.servid=a.prodno
where orderno=:1 and prodno<>:2";
                res = db.ExecuteQuery("core", sql, enumCommandType.SELECT, "Txn130501", ri.ReceivedParam[0], ri.ReceivedParam[1]);
                return res;
            }
            catch (Exception ex)
            {
                res.ResultNo = 9110002;
                res.ResultDesc = "Програм руу нэвтрэхэд алдаа гарлаа" + ex.Message;

                EServ.Shared.Static.WriteToLogFile("Error.log", ex.Message + ex.Source + ex.StackTrace);

                return res;
            }
            finally
            {
                lg.item.Desc = "Захиалгын хуваарьт орсон үйлчилгээнүүдийн жагссалт авах";
            }
        }
        #endregion
    }
}