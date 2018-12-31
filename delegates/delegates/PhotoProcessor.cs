using System;

namespace delegates
{
  public class PhotoProcessor
  {
    
    public void Process(string path, Action<Photo> photoFiltersHandler)
    {
      var photo = new Photo();

      photoFiltersHandler(photo);

      photo.Save();
    }
  }
}