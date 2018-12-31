namespace delegates
{
  public class PhotoProcessor
  {
    public void Process(string path)
    {
      var photo = new Photo();

      var filters = new PhotoFilters();
      filters.ApplyBrightness(photo);
      filters.ApplyContrast(photo);
      filters.Resize(photo);

      photo.Save();
    }
  }
}