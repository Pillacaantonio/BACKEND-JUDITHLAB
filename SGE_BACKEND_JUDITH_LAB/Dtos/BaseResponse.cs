namespace SGE_BACKEND_JUDITH_LAB.Dtos
{
    public class BaseResponse<T>
    {
        public bool IsSucces { get; set; }
        public T? Data { get; set; }
        public string Mensaje { get; set; } = null!;
        public object? innerExeption { get; set; }
        public BaseResponse()
        {
            IsSucces = true;
        }
    }
}
