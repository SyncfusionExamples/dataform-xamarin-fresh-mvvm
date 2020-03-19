# How to bind data object in Xamarin.Forms DataForm (SfDataForm) using Fresh MVVM framework

The [SfDataForm](https://help.syncfusion.com/xamarin/dataform/getting-started) allows you to work with FreshMVVM framework. To achieve this, follow the below steps:

Step 1: Install the [FreshMVVM](https://www.nuget.org/packages/FreshMvvm/) NuGet package in your shared code project.

Step 2: Create your XAML page (view) with name ending with “Page”.

``` c#
namespace DataFormXamarin
{
    public partial class DataFormPage : ContentPage
    {
        public DataFormPage()
        {
            InitializeComponent();
        }
    }
}
```
**Step 3:** Create a page model with the name ending with PageModel and inherit [FreshBasePageModel](https://github.com/rid00z/FreshMvvm/blob/master/src/FreshMvvm/FreshBasePageModel.cs). If your Page name is MainPage, then the PageModel name should be MainPageModel and the namespace of Page and PageModel should be the same. In this PageModel, you can keep the ViewModel related properties.
``` c#
namespace DataFormXamarin
{
    public class DataFormPageModel : FreshBasePageModel
    {
       
    }
}
```
**Step 4:** To raise property changed notifier, use RaisePropertyChanged method of base class in your PageModel.
``` c#
namespace DataFormXamarin
{
    public class DataFormPageModel : FreshBasePageModel
    {
        private ContactsInfo contactsInfo;
        public ContactsInfo ContactsInfo
        {
            get { return this.contactsInfo; }
            set
            {
                this.contactsInfo = value;
                this.RaisePropertyChanged("ContactsInfo");
            }
        }
    }
}
```
**Step 5:** Set MainPage using PageModel in your App.xaml.cs file.
``` c#
public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        var page = FreshPageModelResolver.ResolvePageModel<DataFormPageModel>();
        var basicNavContainer = new FreshNavigationContainer(page);
        MainPage = basicNavContainer;
    }
}
```
**Step 6:** Bind the data to the SfDataform [DataObject](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataForm.XForms~Syncfusion.XForms.DataForm.SfDataForm~DataObject.html) without mentioning the binding context.
``` xml
<dataForm:SfDataForm x:Name="dataForm" 
DataObject="{Binding ContactsInfo}" 
LayoutOptions="TextInputLayout" />
```
