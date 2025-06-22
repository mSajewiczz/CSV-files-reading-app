namespace apprenticeship_project.Model;

public class LineModel
{
    public DateTime Date { get; private set; }
    public double Quantity { get; private set; }
    public double Value { get; private set; }

    public LineModel(string line)
    {
        var group = "";
        var date = "";
        var quantity = "";
        var value = "";
        var splitedLine = line.Split(';');
        var counter = 0;

        foreach (var item in splitedLine)
        {
            if (counter == 2)
            {
                quantity = item;
            }
            else if (counter == 3)
            {
                date = item;
            }
            else if (counter == 5)
            {
                var correctItem = item.Replace('.', ',');
                value = correctItem;
            }

            counter++;
        }

        Date = DateTime.Parse(date);
        Quantity = double.Parse(quantity);
        Value = double.Parse(value);
    }
}