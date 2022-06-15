
// namespace WPFPasswordValidation
// {
//     /// <summary>
//     /// Interaction logic for MainWindow.xaml
//     /// </summary>
//     public partial class MainWindow : Window
//     {
//         private int _noOfErrors = 0;

//         BindingExpression be = null;
//         public MainWindow()
//         {
//             InitializeComponent();

//             Person p = new Person();
//             p.Name = "abc";            
//             p.Password = "1234";
//             this.DataContext = p;

//         }

//         private void Validation_Error(object sender, ValidationErrorEventArgs e)
//         {
//             if (e.Action == ValidationErrorEventAction.Added)
//                 _noOfErrors++;
//             else
//                 _noOfErrors--;
//         }

//         private void Save_Executed(object sender, ExecutedRoutedEventArgs e)
//         {

//         }

//         private void Save_CanExecute(object sender, CanExecuteRoutedEventArgs e)
//         {

//             be = this.txtName.GetBindingExpression(TextBox.TextProperty);
//             be.UpdateSource();

//             be = this.txtPassword.GetBindingExpression(PasswordBoxAssistant.BoundPassword);
//             be.UpdateSource();            

//             e.CanExecute = _noOfErrors == 0;
//             e.Handled = true;
//         }
//     }

//     public class StringRangeValidationRule : ValidationRule
//     {
//         private int _minimumLength = -1;
//         private int _maximumLength = -1;
//         private string _errorMessage;

//         public int MinimumLength
//         {
//             get { return _minimumLength; }
//             set { _minimumLength = value; }
//         }

//         public int MaximumLength
//         {
//             get { return _maximumLength; }
//             set { _maximumLength = value; }
//         }

//         public string ErrorMessage
//         {
//             get { return _errorMessage; }
//             set { _errorMessage = value; }
//         }

//         public override ValidationResult Validate(object value,
//             CultureInfo cultureInfo)
//         {
//             ValidationResult result = new ValidationResult(true, null);
//             string inputString = (value ?? string.Empty).ToString();
//             if (inputString == null)
//             {
//                 inputString = string.Empty;
//             }

//             if (inputString.Length < this.MinimumLength ||
//                 (this.MaximumLength > 0 &&
//                     inputString.Length > this.MaximumLength))
//             {
//                 result = new ValidationResult(false, this.ErrorMessage);
//             }
//             return result;
//         }
//     }

//     public static class PasswordBoxAssistant
//     {
//         public static readonly DependencyProperty BoundPassword =
//             DependencyProperty.RegisterAttached("BoundPassword", typeof(string), typeof(PasswordBoxAssistant), new PropertyMetadata(string.Empty, OnBoundPasswordChanged));

//         public static readonly DependencyProperty BindPassword = DependencyProperty.RegisterAttached(
//             "BindPassword", typeof(bool), typeof(PasswordBoxAssistant), new PropertyMetadata(false, OnBindPasswordChanged));

//         private static readonly DependencyProperty UpdatingPassword =
//             DependencyProperty.RegisterAttached("UpdatingPassword", typeof(bool), typeof(PasswordBoxAssistant), new PropertyMetadata(false));

//         private static void OnBoundPasswordChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
//         {
//             PasswordBox box = d as PasswordBox;

//             // only handle this event when the property is attached to a PasswordBox
//             // and when the BindPassword attached property has been set to true
//             if (d == null || !GetBindPassword(d))
//             {
//                 return;
//             }

//             // avoid recursive updating by ignoring the box's changed event
//             box.PasswordChanged -= HandlePasswordChanged;

//             string newPassword = (string)e.NewValue;

//             if (!GetUpdatingPassword(box))
//             {
//                 box.Password = newPassword;
//             }

//             box.PasswordChanged += HandlePasswordChanged;
//         }

//         private static void OnBindPasswordChanged(DependencyObject dp, DependencyPropertyChangedEventArgs e)
//         {
//             // when the BindPassword attached property is set on a PasswordBox,
//             // start listening to its PasswordChanged event

//             PasswordBox box = dp as PasswordBox;

//             if (box == null)
//             {
//                 return;
//             }

//             bool wasBound = (bool)(e.OldValue);
//             bool needToBind = (bool)(e.NewValue);

//             if (wasBound)
//             {
//                 box.PasswordChanged -= HandlePasswordChanged;
//             }

//             if (needToBind)
//             {
//                 box.PasswordChanged += HandlePasswordChanged;
//             }
//         }

//         private static void HandlePasswordChanged(object sender, RoutedEventArgs e)
//         {
//             PasswordBox box = sender as PasswordBox;

//             // set a flag to indicate that we're updating the password
//             SetUpdatingPassword(box, true);
//             // push the new password into the BoundPassword property
//             SetBoundPassword(box, box.Password);
//             SetUpdatingPassword(box, false);
//         }

//         public static void SetBindPassword(DependencyObject dp, bool value)
//         {
//             dp.SetValue(BindPassword, value);
//         }

//         public static bool GetBindPassword(DependencyObject dp)
//         {
//             return (bool)dp.GetValue(BindPassword);
//         }

//         public static string GetBoundPassword(DependencyObject dp)
//         {
//             return (string)dp.GetValue(BoundPassword);
//         }

//         public static void SetBoundPassword(DependencyObject dp, string value)
//         {
//             dp.SetValue(BoundPassword, value);
//         }

//         private static bool GetUpdatingPassword(DependencyObject dp)
//         {
//             return (bool)dp.GetValue(UpdatingPassword);
//         }

//         private static void SetUpdatingPassword(DependencyObject dp, bool value)
//         {
//             dp.SetValue(UpdatingPassword, value);
//         }
//     }

//     public class Person
//     {
//         private string _name;        
//         private string _password;               

//         public string Password
//         {
//             get { return _password; }
//             set { _password = value; }
//         }

//         public string Name
//         {
//             get { return _name; }
//             set
//             {
//                 _name = value;                
//             }
//         }        
//     }

// }