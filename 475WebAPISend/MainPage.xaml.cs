namespace _475WebAPISend
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }


        //private async void OnClicked(object sender, EventArgs e)
        //{
        //    int id = int.Parse(textId.Text);
        //    int price = int.Parse(textPrice.Text);

        //    var url = $"https://moonmile-gyakubiki.azurewebsites.net/api/postbook";
        //    var book = new Book()
        //    {
        //        Id = id,
        //        Price = price
        //    };
        //    // var data = JsonSerializer.SerializeToUtf8Bytes(book);
        //    // var json = System.Text.Encoding.UTF8.GetString(data);
        //    var json = $"{{\"id\": {id}, \"price\": {price} }}";
        //    var context = new StringContent(json);
        //    var cl = new HttpClient();
        //    var response = await cl.PostAsync(url, context);
        //    string text = await response.Content.ReadAsStringAsync();
        //    labelResult.Text = text;
        //}
    }

    //public class MainViewModel : Prism.Mvvm.BindableBase
    //{

    //}

    public class Book
    {
        public int Id { get; set; }
        public int Price { get; set; }
    }
}