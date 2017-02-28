using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bibliotheca_Management_System
{
    public class Connection
    {
        SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=Bibliotheca;Integrated Security=True");
        public SqlConnection ActiveCon()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        #region Manage Books
        public bool AddBook(string bookTitle, string bookAuthor, string year, int qty)
        {
            bool State = false;
            SqlCommand cmd = new SqlCommand("insert into Books(Book_Title, Book_Author, yr_of_publ, Book_Qty, status) values(@title, @author, @yr, @qty, @status)",con);
            cmd.Parameters.AddWithValue("@title", bookTitle);
            cmd.Parameters.AddWithValue("@author", bookAuthor);
            cmd.Parameters.AddWithValue("@yr", year);
            cmd.Parameters.AddWithValue("@qty", qty);
            if (qty > 1)
                cmd.Parameters.AddWithValue("@status", "Available");
            else
                cmd.Parameters.AddWithValue("@status", "Only Library Use");
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                State = true;
            }
            catch(Exception)
            {
            }
            con.Close();
            return State;
        }
        public bool UpdateBook(int ID, string bookTitle, string bookAuthor, string year, int qty)
        {
            bool State = false;
            SqlCommand cmd = new SqlCommand("update Books set Book_Title = @Book_Title, Book_Author = @Book_Author, yr_of_publ = @yrofpubl, Book_Qty = @Book_qty , status = @status where Books.Book_Id = @ID",con);
            cmd.Parameters.AddWithValue("@Book_Title", bookTitle);
            cmd.Parameters.AddWithValue("@Book_Author", bookAuthor);
            cmd.Parameters.AddWithValue("@yrofpubl", year);
            cmd.Parameters.AddWithValue("@Book_qty", qty);
            cmd.Parameters.AddWithValue("@ID", ID);
            if (qty > 1)
                cmd.Parameters.AddWithValue("@status", "Available");
            else
                cmd.Parameters.AddWithValue("@status", "Only Library Use");
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                State = true;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            con.Close();
            return State;
        }
        public bool DeleteBook(int ID)
        {
            bool State = false;
            SqlCommand cmd = new SqlCommand(@"delete from Books where Books.Book_Id = @ID 
delete from Issue_book where book_id = @ID", con);
            cmd.Parameters.AddWithValue("@ID", ID);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                State = true;
            }
            catch(Exception)
            { }
            con.Close();
            return State;
        }
        #endregion

        #region Manage Members
        public bool AddMember(string fullName, string email, string role, string address)
        {
            bool State = false;
            SqlCommand cmd = new SqlCommand("insert into Members(Mem_password, Mem_Name, Mem_Email, Mem_Address, Mem_Role)values(@password, @name, @email, @address, @role)", con);
            cmd.Parameters.AddWithValue("@password", "abc123");
            cmd.Parameters.AddWithValue("@name", fullName);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@role", role);
            cmd.Parameters.AddWithValue("@address", address);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                State = true;
            }
            catch(Exception)
            {
            }
            con.Close();
            return State;
        }
        public bool UpdateMember(int ID, string fullName, string email, string role, string address)
        {
            bool State = false;
            SqlCommand cmd = new SqlCommand("update Members set Mem_Name = @Name, Mem_Email = @Email, Mem_Address = @Address, Mem_Role = @MemRole where Members.Mem_Id = @ID", con);
            cmd.Parameters.AddWithValue("@Name", fullName);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Address", address);
            cmd.Parameters.AddWithValue("@MemRole", role);
            cmd.Parameters.AddWithValue("@ID", ID);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                State = true;
            }
            catch (Exception)
            {
            }
            con.Close();
            return State;
        }
        public bool DeleteMember(int ID)
        {
            bool State = false;
            if (ID == 1) return State;
            SqlCommand cmd = new SqlCommand(@"delete from Members where Members.Mem_Id = @ID
delete from Issue_book where user_id = @ID", con);
            cmd.Parameters.AddWithValue("@ID", ID);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                State = true;
            }
            catch(Exception)
            { }
            con.Close();
            return State;
        }
        #endregion

        #region Circulation
        public bool BookIssue(string fullName, string bookTitle, DateTime issuedate, DateTime returndate, int qty)
        {
            bool State = false;
            SqlCommand cmd = new SqlCommand(@"declare @MemId int, @BookId int, @IssueDate Date = @Issue, @ReturnDate Date = @Return, @QTY int = @number
------------------------------
select @BookId = Books.Book_Id from Books where Books.Book_Title = @BookTitle
select @MemId = Members.Mem_Id from Members where Members.Mem_Name = @MemberName
------------------------------
update Books set Book_Qty = @QTY where Book_Title = @BookTitle
insert into Issue_book(book_id, user_id, issue_date, due_date) values(@BookId, @MemId, @IssueDate, @ReturnDate)", con);
            cmd.Parameters.AddWithValue("@MemberName", fullName);
            cmd.Parameters.AddWithValue("@BookTitle", bookTitle);
            cmd.Parameters.AddWithValue("@Issue", issuedate);
            cmd.Parameters.AddWithValue("@Return", returndate);
            cmd.Parameters.AddWithValue("@number", qty);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                State = true;
            }
            catch(Exception)
            {
            }
            con.Close();
            return State;
        }
        public bool IssueUpdate(int ID, string fullName, string bookTitle, DateTime returndate)
        {
            bool State = false;
            SqlCommand cmd = new SqlCommand(@"declare @returnDate Date = @Return
declare @MemName varchar(100)= @MemberName, @BookTitle varchar(100) = @Book_Title
update Issue_book set user_id = (select Members.Mem_Id from Members where Members.Mem_Name = @MemName),
book_id = (select Books.Book_Id from Books where Books.Book_Title = @BookTitle),
due_date = @returnDate
where Issue_book.issue_id = @ID", con);
            cmd.Parameters.AddWithValue("@MemberName", fullName);
            cmd.Parameters.AddWithValue("@Book_Title", bookTitle);
            cmd.Parameters.AddWithValue("@Return", returndate);
            cmd.Parameters.AddWithValue("@ID", ID);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                State = true;
            }
            catch (Exception)
            {
            }
            con.Close();
            return State;
        }
        public bool statusUpdate(string bookTitle)
        {
            bool State = false;
            SqlCommand cmd = new SqlCommand("update Books set status = @status where Book_Title = @Title", con);
            cmd.Parameters.AddWithValue("@status", "Library Only");
            cmd.Parameters.AddWithValue("@Title", bookTitle);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                State = true;
            }
            catch (Exception)
            {
            }
            con.Close();
            return State;
        }
        public int fine(int ID)
        {
            int amount = 0, days = 0; ;
            SqlCommand cmd = new SqlCommand(@"declare @date Date
select @date = due_date from Issue_book where issue_id = @ID
                        select DATEDIFF(day, @date, GETDATE())", con);
            cmd.Parameters.AddWithValue("@ID", ID);
            SqlDataReader dr = null;
            con.Open();
            try
            {
                dr = cmd.ExecuteReader();
                dr.Read();
                days = dr.GetInt32(0);
            }
            catch (Exception)
            {
            }
            con.Close();
            if (days > 0)
                amount = 1 * days;
            return amount;
        }
        public void ReturnUpdate(string bookTitle)
        {
            SqlCommand cmd = new SqlCommand("update Books set status = @status where Book_Title = @Title", con);
            cmd.Parameters.AddWithValue("@status", "Available");
            cmd.Parameters.AddWithValue("@Title", bookTitle);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
            }
            con.Close();
        }

        public bool DeleteIssue(int ID, int qty, string title)
        {
            bool State = false;
            SqlCommand cmd = new SqlCommand(@"update Books set Book_Qty = @qty where Book_Title = @Book_Title
delete from Issue_book where Issue_book.issue_id = @ID", con);
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@qty", qty);
            cmd.Parameters.AddWithValue("@Book_Title", title);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                State = true;
            }
             catch(Exception)
            { }
            con.Close();
            return State;
        }
        public int bookQty(string name)
        {
            int qty = 0;
            SqlDataReader dr = null;
            SqlCommand cmd = new SqlCommand("select Book_Qty from Books where Book_Title = @name", con);
            cmd.Parameters.AddWithValue("@name", name);
            con.Open();
            try
            {
                dr = cmd.ExecuteReader();
                dr.Read();
                qty = dr.GetInt32(0);
            }
            catch (Exception)
            { }
            con.Close();
            return qty;
        }
        public string Recpassword(string name)
        {
            string pass = "meere";
            SqlDataReader dr = null;
            SqlCommand cmd = new SqlCommand("select Mem_password from Members where Mem_Email = @name", con);
            cmd.Parameters.AddWithValue("@name", name);
            con.Open();
            try
            {
                dr = cmd.ExecuteReader();
                dr.Read();
                pass = dr.GetString(0);
            }
            catch (Exception)
            { }
            con.Close();
            return pass;
        }
        #endregion

        #region Listing
        public DataTable allBooks()
        {
            DataTable tbl = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from Books", con);
            con.Open();
            try
            {
                SqlDataReader sr = cmd.ExecuteReader();
                tbl.Load(sr);
            }
            catch(Exception)
            { }
            con.Close();
            return tbl;
        }
        public DataTable allUsers()
        {
            DataTable tbl = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from Members", con);
            con.Open();
            try
            {
                SqlDataReader sr = cmd.ExecuteReader();
                tbl.Load(sr);
            }
            catch (Exception)
            { }
            con.Close();
            return tbl;
        }
        public DataTable allLending()
        {
            DataTable tbl = new DataTable();
            SqlCommand cmd = new SqlCommand(@"create table #table
(
IncomingID int identity(1,1) primary key not null,
issue_id int null,
book_name varchar(150) null,
Mem_Name varchar(100) null,
issue_date Date null,
due_date Date null
)
insert into #table(issue_id, issue_date, due_date) select issue_id, issue_date, due_date from Issue_book
declare @length int = 0, @counter int = 1

select @length = COUNT(#table.IncomingID) from #table

declare @ID int
while @length >= @counter
begin
select @ID = #table.issue_id from #table where #table.IncomingID = @counter
update #table set Mem_Name = (select Members.Mem_Name from Members where Members.Mem_Id = (select Issue_book.user_id from Issue_book where Issue_book.issue_id = @ID)),
book_name = (select Books.Book_Title from Books where Books.Book_Id = (select Issue_book.book_id from Issue_book where Issue_book.issue_id = @ID))
where IncomingID = @counter
set @counter+=1
end
select * from #table", con);
            con.Open();
            try
            {
                SqlDataReader sr = cmd.ExecuteReader();
                tbl.Load(sr);
                tbl.Columns.Remove(tbl.Columns[0]);
            }
            catch (Exception)
            { }
            con.Close();
            return tbl;
        }
        public DataTable guestBooks(string text)
        {
            DataTable tbl = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from Books where Book_Author = @author or Book_Title = @book", con);
            cmd.Parameters.AddWithValue("@author", text);
            cmd.Parameters.AddWithValue("@book", text);
            con.Open();
            try
            {
                SqlDataReader sr = cmd.ExecuteReader();
                tbl.Load(sr);
            }
            catch (Exception)
            { }
            con.Close();
            return tbl;
        }
        public DataTable BooksTaken(int text)
        {
            DataTable tbl = new DataTable();
            SqlCommand cmd = new SqlCommand(@"create table #table
(
IncomingID int identity(1,1) primary key not null,
issue_id int null,
book_name varchar(150) null,
due_date Date null
)
insert into #table(issue_id, due_date) select issue_id, due_date from Issue_book where user_id = @userr
declare @length int = 0, @counter int = 1

select @length = COUNT(#table.IncomingID) from #table

declare @ID int
while @length >= @counter
begin
select @ID = #table.issue_id from #table where #table.IncomingID = @counter
update #table set book_name = (select Books.Book_Title from Books where Books.Book_Id = (select Issue_book.book_id from Issue_book where Issue_book.issue_id = @ID))
where IncomingID = @counter
set @counter+=1
end
select * from #table", con);
            cmd.Parameters.AddWithValue("@userr", text);
            con.Open();
            try
            {
                SqlDataReader sr = cmd.ExecuteReader();
                tbl.Load(sr);
                tbl.Columns.Remove(tbl.Columns[0]);
            }
            catch (Exception)
            { }
            con.Close();
            return tbl;
        }
        public DataTable searchUser(string text)
        {
            DataTable tbl = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from Members where Mem_Name = @name", con);
            cmd.Parameters.AddWithValue("@name", text);
            con.Open();
            try
            {
                SqlDataReader sr = cmd.ExecuteReader();
                tbl.Load(sr);
            }
            catch (Exception)
            { }
            con.Close();
            return tbl;
        }
        public DataTable searchUserID(int ID)
        {
            DataTable tbl = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from Members where Mem_Id = @ID", con);
            cmd.Parameters.AddWithValue("@nID", ID);
            con.Open();
            try
            {
                SqlDataReader sr = cmd.ExecuteReader();
                tbl.Load(sr);
            }
            catch (Exception)
            { }
            con.Close();
            return tbl;
        }
        public List<string> MemFullName()
        {
            List<string> list = new List<string>();
            SqlCommand cmd = new SqlCommand("select Mem_Name from Members", con);
            con.Open();
            try
            {
                SqlDataReader sr = cmd.ExecuteReader();
                while (sr.Read())
                {
                    list.Add(sr[0].ToString());
                }
            }
            catch(Exception)
            { }
            con.Close();
            return list;
        }
        public List<string> BookName()
        {
            List<string> list = new List<string>();
            SqlCommand cmd = new SqlCommand("select Book_Title from Books", con);
            con.Open();
            try
            {
                SqlDataReader sr = cmd.ExecuteReader();
                while (sr.Read())
                {
                    list.Add(sr[0].ToString());
                }
            }
            catch (Exception)
            { }
            con.Close();
            return list;
        }
        public List<string> AuthorName()
        {
            List<string> list = new List<string>();
            SqlCommand cmd = new SqlCommand("select Book_Author from Books", con);
            con.Open();
            try
            {
                SqlDataReader sr = cmd.ExecuteReader();
                while (sr.Read())
                {
                    list.Add(sr[0].ToString());
                }
            }
            catch (Exception)
            { }
            con.Close();
            return list;
        }
        public List<string> memID()
        {
            List<string> list = new List<string>();
            SqlCommand cmd = new SqlCommand("select Mem_Id from Members", con);
            con.Open();
            try
            {
                SqlDataReader sr = cmd.ExecuteReader();
                while (sr.Read())
                {
                    list.Add(sr[0].ToString());
                }
            }
            catch (Exception)
            { }
            con.Close();
            return list;
        }
        public DataTable DueBooks()
        {
            DataTable tbl = new DataTable();
            SqlCommand cmd = new SqlCommand(@"create table #table
(
IncomingID int identity(1,1) primary key not null,
ID int null,
UserName varchar(150) null,
BookName varchar(150) null,
ReturnD Date null
)
declare @date Date = @Today
insert into #table(ID, ReturnD) select Issue_book.issue_id, Issue_book.due_date from Issue_book
declare @length int = 0, @counter int = 1, @ID int
select @length = COUNT(#table.IncomingID) from #table
while @length >= @counter
begin
select @ID = #table.ID from #table where #table.IncomingID = @counter
update #table set UserName = (select Members.Mem_Name from Members where Members.Mem_Id = (select Issue_book.user_id from Issue_book where Issue_book.issue_id = @ID)),
BookName = (select Books.Book_Title from Books where Books.Book_Id = (select Issue_book.book_id from Issue_book where Issue_book.issue_id = @ID))
where #table.ID = @ID
set @counter += 1
end
select * from #table where @date >= ReturnD", con);
            cmd.Parameters.AddWithValue("@Today", DateTime.Now);
            con.Open();
            try
            {
                SqlDataReader sr = cmd.ExecuteReader();
                tbl.Load(sr);
                tbl.Columns.Remove(tbl.Columns[0]);
                tbl.Columns.Remove(tbl.Columns[0]);
                tbl.Columns.Remove(tbl.Columns[2]);
            }
            catch(Exception)
            { }
            con.Close();
            return tbl;
        }
        #endregion

        #region profile
        public string[] profile(string name)
        {
            string[] person = new string[3];
            SqlCommand cmd = new SqlCommand("select * from Members where Mem_Name = @fName", con);
            cmd.Parameters.AddWithValue("@Fname", name);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                  //  person[0] = reader.GetString(0);
                    person[0] = reader.GetString(3);
                    person[1] = reader.GetString(4);
                    person[2] = reader.GetString(5);
                }
            }
            con.Close();
            return person;
        }

        public int ID(string name)
        {
            int id = 0;
            SqlCommand cmd = new SqlCommand("select * from Members where Mem_Name = @fName", con);
            cmd.Parameters.AddWithValue("@Fname", name);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                }
            }
            con.Close();
            return id;
        }

        public string password(string name)
        {
            string pass = "";
            SqlCommand cmd = new SqlCommand("select * from Members where Mem_Name = @fName", con);
            cmd.Parameters.AddWithValue("@Fname", name);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    pass = reader.GetString(1);
                }
            }
            con.Close();
            return pass;
        }

        public bool UpdatePassword(int ID, string pass)
        {
            bool State = false;
            SqlCommand cmd = new SqlCommand("update Members set Mem_password = @pass where Members.Mem_Id = @ID", con);
            cmd.Parameters.AddWithValue("@pass", pass);
            cmd.Parameters.AddWithValue("@ID", ID);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                State = true;
            }
            catch (Exception)
            {
            }
            con.Close();
            return State;
        }

        public bool UpdateProfile(int ID, string email, string address)
        {
            bool State = false;
            SqlCommand cmd = new SqlCommand("update Members set Mem_Email = @email, Mem_Address = @address where Members.Mem_Id = @ID", con);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@ID", ID);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                State = true;
            }
            catch (Exception)
            {
            }
            con.Close();
            return State;
        }


        #endregion

    }
}
