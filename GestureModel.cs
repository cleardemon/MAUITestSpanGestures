using System.Windows.Input;

namespace TestSpanGestures;

public class GestureModel
{
    public ICommand TapCommand => new Command(page => ((Page)page).DisplayAlert("Clicked the link", "Woo", "OK"));

    public List<string> SomeItems
    {
        get
        {
            var list = new List<string>();

            for (var index = 0; index < 100; index++)
            {
                list.Add($"Item {index}");
            }

            return list;
        }
    }
}