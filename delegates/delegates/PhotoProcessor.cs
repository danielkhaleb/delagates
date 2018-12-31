namespace delegates
{
  public class PhotoProcessor
  {
    public delegate void PhotoFiltersHandler(Photo photo);
    public void Process(string path, PhotoFiltersHandler photoFiltersHandler)
    {
      var photo = new Photo();

      photoFiltersHandler(photo);

      photo.Save();
    }
  }
}