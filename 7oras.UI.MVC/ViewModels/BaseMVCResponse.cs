using _7oras.Domain.Shared;

namespace _7oras.UI.MVC.ViewModels
{
    //For Json Response
    public class BaseMVCResponse<TResVM> where TResVM : class
    {
        public ResponseStatusEnum Result { get; set; }
        public TResVM Data { get; set; }
        public BaseErrorResponse ErrorDetails { get; set; }

    }
}
