# How to work with RTL in Xamarin.Forms Accordion (SfAccordion)

You can use [SfAccordion](https://help.syncfusion.com/xamarin/accordion/getting-started?) with [RTL](https://docs.microsoft.com/en-us/xamarin/xamarin-forms/app-fundamentals/localization/right-to-left) in Xamarin.Forms by setting the [FlowDirection](https://docs.microsoft.com/en-us/dotnet/api/xamarin.forms.visualelement.flowdirection?view=xamarin-forms#Xamarin_Forms_VisualElement_FlowDirection) property for SfAccordion.

You can also refer the following article.

https://www.syncfusion.com/kb/11444/how-to-work-with-rtl-in-xamarin-forms-accordion-sfaccordion

**XAML**

Set **FlowDirection** as **RightToLeft** to Accordion.
``` xml
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:syncfusion="clr-namespace:Syncfusion.XForms.Accordion;assembly=Syncfusion.Expander.XForms"
             x:Class="AccordionXamarin.MainPage" Padding="{OnPlatform iOS='0,40,0,0'}">
 
    <ContentPage.Content>
        <syncfusion:SfAccordion x:Name="Accordion" ExpandMode="SingleOrNone" Margin="5" BindableLayout.ItemsSource="{Binding Info}" FlowDirection="{OnPlatform Android='RightToLeft', iOS='RightToLeft'}">
            <BindableLayout.ItemTemplate>
                <DataTemplate>
                    <syncfusion:AccordionItem x:Name="AccordionItem">
                        <syncfusion:AccordionItem.Header>
                            <Grid HeightRequest="50">
                                <Label Text="{Binding Name}" VerticalOptions="Center" HorizontalOptions="StartAndExpand"/>
                            </Grid>
                        </syncfusion:AccordionItem.Header>
                        <syncfusion:AccordionItem.Content>
                            <Grid Padding="5" BackgroundColor="NavajoWhite">
                                <Label Text="{Binding Description}" VerticalOptions="Center" HorizontalOptions="StartAndExpand"/>
                            </Grid>
                        </syncfusion:AccordionItem.Content>
                    </syncfusion:AccordionItem>
                </DataTemplate>
            </BindableLayout.ItemTemplate>
        </syncfusion:SfAccordion>
    </ContentPage.Content>
 
</ContentPage>
```
In UWP platform, the **ScrollView** is not changed when RTL is enabled (framework issue). To overcome this issue, set the FlowDirection property in constructor of **MainPage** in UWP renderer.

**C#**

Set **FlowDirection** to **RightToLeft** in constructor of MainPage
``` c#
namespace AccordionXamarin.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();
            SfAccordionRenderer.Init();
            this.FlowDirection = FlowDirection.RightToLeft;
            LoadApplication(new AccordionXamarin.App());
        }
    }
}
```
**Output**

![AccordionRTL](https://github.com/SyncfusionExamples/accordion-rtl-xamarin/blob/master/ScreenShots/AccordionRTL.gif)
