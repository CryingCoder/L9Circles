namespace L9Circles
{
    internal class Circle
    {

        //SETTING FIELD TO USE WHEN CALLING RADIUS
        public double radius;

        
        //SETTING PROPERTY TO USE FIELD FOR RADIUS = RAD
        public Circle(double rad)
        {
            radius = rad;

        }


        //METHOD FOR CALCULATING CIRCUMFERENCE OF CIRCLE
        public double CalculateCircumference()
        {
            return 2 * (Math.PI * radius);
        }

        
        //METHOD FOR FORMATTING CIRCUMFERENCE INTO A ROUNDED DECIMAL VALUE USING THE FORMAT METHOD IN CLASS CIRCLE
        public string CalculateFormattedCircumference()
        {
            string formattedCircumference = FormatNumber(CalculateCircumference());
            return formattedCircumference;
        }


        //METHOD FOR CALCULATING AREA OF CIRCLE
        public double CalculateArea()
        {   
            double area = Math.PI * radius * radius;
            return area;
                
        }


        //METHOD FOR FORMATTING AREA INTO A ROUNDED DECIMAL VALUE USING THE FORMAT METHOD IN CLASS CIRCLE
        public string CalculateFormattedArea()
        {
            string formattedArea = FormatNumber(CalculateArea());
            return formattedArea;
        }


        //METHOD FOR ROUDNING DECIMAL VALUES - WILL PASS TO OTHER METHODS
        private string FormatNumber(double x)
        {
            
            return Math.Round(x,2).ToString();
        }
    }
}
