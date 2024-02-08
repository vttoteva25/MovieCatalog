namespace MC.ApplicationServices.Messaging.Responses
{
    public class GetByTitleResponse : ResponseServiceBase
    {
        public List<MovieModel> Movies { get; set; }
    }
}
