using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IService
{

	// TODO: Add your service operations here
	[OperationContract]
	List<Book> GetAllBooks();
	[OperationContract]
	void AddBook(Book book);
	[OperationContract]
	void UpdateBook(Book book);
	[OperationContract]
	void DeleteBook(Book book);
}

[DataContract]
public class Book
{
	[DataMember]
	public int BookID { get; set; }
	[DataMember]
	public string BookTitle { get; set; }
	[DataMember]
	public float BookPrice { get; set; }
    [DataMember]
	public int BookQuantity { get; set; }


}

// Use a data contract as illustrated in the sample below to add composite types to service operations.	