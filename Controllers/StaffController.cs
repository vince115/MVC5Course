using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using MVC5Course.Models;

namespace MVC5Course.Controllers
{
    public class StaffController : Controller
    {
        // 建立資料庫上下文物件
        private DBContext db = new DBContext();

        // GET: Staff
        // 顯示所有員工資料
        public ActionResult Index()
        {
            // 將所有員工資料傳遞給檢視
            return View(db.Staffs.ToList());
        }

        // GET: Staff/Details/5
        // 顯示特定員工的詳細資料
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                // 如果 ID 為空，回傳 400 錯誤 (Bad Request)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            // 根據 ID 從資料庫查找員工資料
            Staff staff = db.Staffs.Find(id);
            if (staff == null)
            {
                // 如果找不到員工，回傳 404 錯誤 (Not Found)
                return HttpNotFound();
            }

            // 將員工資料傳遞給檢視
            return View(staff);
        }

        // GET: Staff/Create
        // 顯示新增員工的表單
        public ActionResult Create()
        {
            return View();
        }

        // POST: Staff/Create
        // 接收新增員工表單提交的資料
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Position,Salary")] Staff staff)
        {
            if (ModelState.IsValid)
            {
                // 將員工資料加入資料庫
                db.Staffs.Add(staff);
                db.SaveChanges();

                // 新增完成後跳轉至員工列表
                return RedirectToAction("Index");
            }

            return View(staff);
        }

        // GET: Staff/Edit/5
        // 顯示編輯員工的表單
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                // 如果 ID 為空，回傳 400 錯誤
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            // 根據 ID 從資料庫查找員工資料
            Staff staff = db.Staffs.Find(id);
            if (staff == null)
            {
                // 如果找不到員工，回傳 404 錯誤
                return HttpNotFound();
            }

            // 將員工資料傳遞給檢視
            return View(staff);
        }

        // POST: Staff/Edit/5
        // 接收編輯員工表單提交的資料
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Position,Salary")] Staff staff)
        {
            if (ModelState.IsValid)
            {
                // 更新資料庫中的員工資料
                db.Entry(staff).State = EntityState.Modified;
                db.SaveChanges();

                // 更新完成後跳轉至員工列表
                return RedirectToAction("Index");
            }

            return View(staff);
        }

        // GET: Staff/Delete/5
        // 顯示刪除員工的確認頁面
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                // 如果 ID 為空，回傳 400 錯誤
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            // 根據 ID 從資料庫查找員工資料
            Staff staff = db.Staffs.Find(id);
            if (staff == null)
            {
                // 如果找不到員工，回傳 404 錯誤
                return HttpNotFound();
            }

            // 將員工資料傳遞給檢視
            return View(staff);
        }

        // POST: Staff/Delete/5
        // 接收刪除員工的確認
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            // 從資料庫中刪除員工資料
            Staff staff = db.Staffs.Find(id);
            db.Staffs.Remove(staff);
            db.SaveChanges();

            // 刪除完成後跳轉至員工列表
            return RedirectToAction("Index");
        }

        // 釋放資料庫資源
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
