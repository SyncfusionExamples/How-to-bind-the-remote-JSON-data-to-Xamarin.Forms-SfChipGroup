# How-to-bind-the-remote-JSON-data-to-Xamarin.Forms-SfChipGroup

This example explains how to bind JSON data to SfChipGroup.Please refer KB links for more details,

[How to bind remote JSON data to Xamarin.Forms chip group (SfChipGroup)](https://www.syncfusion.com/kb/11370/?utm_medium=listing&utm_source=github-examples)

You can bind the data from the remote JSON file in Xamarin.Forms SfChipGroup using the ItemsSource property.

**[XAML]**

The JSON data can be bound to the SfChipGroup ItemsSource property.
```
  <buttons:SfChipGroup 
    ItemsSource="{Binding Data}" 
    ChipPadding="8,8,0,0" 
    DisplayMemberPath="ShipCity">
            <buttons:SfChipGroup.ChipLayout>
                <FlexLayout 
      HorizontalOptions="Start" 
      VerticalOptions="Center" 
      Direction="Row" 
      Wrap="Wrap"
      JustifyContent="Start"
      AlignContent="Start" 
      AlignItems="Start"/>
            </buttons:SfChipGroup.ChipLayout>
        </buttons:SfChipGroup>
```
**[C#]**

 Accessed the JSON file from remote server and deserialize the object to return as collection of model.

``` 
private const string Url = "https://ej2services.syncfusion.com/production/web-services/api/Orders"; //This url is a free public api intended for demos
 
private readonly HttpClient _client = new HttpClient(); //Creating a new instance of HttpClient. (Microsoft.Net.Http)
 
        private ObservableCollection<Model> data;
 
        public ObservableCollection<Model> Data
        {
            get { return data; }
            set
            {
                data = value;
                OnPropertyChanged("Data");
            }
        }
 
      
 
        public ViewModel()
        {
            Data = new ObservableCollection<Model>();
            GetData();
 
        }
 
       async void GetData()
        {
            string content = await _client.GetStringAsync(Url); //Sends a GET request to the specified Uri and returns the response body as a string in an asynchronous operation
            var json_Datas = JsonConvert.DeserializeObject<ObservableCollection<Model>>(content); //Deserializes or converts JSON String into a collection of Post
            Data = json_Datas;
        }
```

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

 

 
