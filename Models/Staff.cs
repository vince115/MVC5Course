//只定義模型類別，描述資料的結構：
namespace MVC5Course.Models
{
	public class Staff
	{
		public int Id { get; set; }           // 員工 ID
		public string Name { get; set; }      // 員工姓名
		public string Position { get; set; }  // 職位
		public decimal Salary { get; set; }   // 薪資
	}
}
