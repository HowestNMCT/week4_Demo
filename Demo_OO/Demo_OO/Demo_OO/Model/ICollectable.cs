namespace Demo_OO.Model
{
    /// <summary>
    /// interface to determine collectable items, 
    /// such as wine or comic books
    /// </summary>
    public interface ICollectable
    {
        int YearOfOrigin { get; set; }
    }
}
