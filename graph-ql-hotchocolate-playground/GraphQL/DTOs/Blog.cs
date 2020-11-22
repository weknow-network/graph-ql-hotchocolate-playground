namespace Bnaya.Samples
{
    public record Blog (int id, string name, params Post[] post);
}
