private NorthwindEntities _context = new NorthwindEntities();
private CollectionViewSource _customerViewSource;

public MainWindow()
{
    InitializeComponent();
    _customerViewSource = (CollectionViewSource)FindResource("customerViewSource");
}

private void Window_Loaded(object sender, RoutedEventArgs e)
{
    _context.Customers.Load();
    _customerViewSource.Source = _context.Customers.Local;
}

private void Save_Click(object sender, RoutedEventArgs e)
{
    _context.SaveChanges();
}
