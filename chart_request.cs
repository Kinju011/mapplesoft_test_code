class ChartRequest
{
    public method var;
    public chart_params var;
    

    public initialize(method, params)
    {
        method = method;
        chart_params = DEFAULT.merge(params);
        chart_params.symbolize_keys!();
    }

    public string url
    {
        url = "http://host_name:port/path?param";
    }

    public string result_name
    {
        //check if value exists in chart_params or not is not than go to else part
        if chart_params < 1
        {
            return chart_params;
        }
        else
        {
            return method;
        }
    }

    public void query_params
    {
        date_range = parse_date_range(chart_params.date_range);
        
    }

    public date parse_date_range(string date)
    {
        try
        {
            if chart_params.start_date && chart_params.end_date
            {
                 return chart_params;
            }
            else
            {
                dates = date.split(' - ');
                return dates;
            }   
        }
        catch (System.Exception)
        {
            days_to_display = chart_params.fetch(:default_days_to_display, 30).days.ago.to_date;
            days_to_display..Date.current;
        }        
    }
}