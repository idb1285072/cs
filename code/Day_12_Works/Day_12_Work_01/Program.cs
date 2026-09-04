using m = HR.Mgr;
using  FrontOffice;

class Program
{
    static void Main()
    {
        //HR.Mgr.IManager manager;
        //manager = new HR.Mgr.Manager();

        m.IManager manager;
        manager = new m.Manager();

        //FrontOffice.CustomerEnquiry customerEnquiry;
        //customerEnquiry = new FrontOffice.CustomerEnquiry();
        CustomerEnquiry customerEnquiry;
        customerEnquiry = new CustomerEnquiry();
    }
}