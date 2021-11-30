namespace Bài_Tập_4
{
    public class PhotoBook
    {
        public int numPages;
        

        //1.Mặc định số trang sách ( Tuỳ chọn gán số)
        public PhotoBook()
        {
            numPages = 16;
        }
        
        //2.Cho người code tự nhập số mình mong muôn nếu không nhập trở lại mặc định (1.)
        public PhotoBook(int numPages)
        {
            this.numPages = numPages;    // Hỏi anh Trí
            
        }

        public int GetNumberPages() // Trả về số trang ở trên để lấy dữ liệu in ra màn hình 
        {
            return numPages;
        }
        
    }
}