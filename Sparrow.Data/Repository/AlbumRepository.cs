﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sparrow.BLL.Model;

namespace Sparrow.Data.Repository
{
    public class AlbumRepository
    {
        public List<AlbumModel> GetAlbums(int artistId)
        {
            try
            {
                var model = new List<AlbumModel>();
                using (var context = new SparrowMusicEntities())
                {
                    var albums = context.SPRW_ALBUM.Where(i => i.SPRW_ARTIST.ARTIST_ID == artistId).ToList();

                    foreach (var album in albums)
                    {
                        var albumModel = new AlbumModel
                        {
                            AlbumId = album.ALBUM_ID,
                            AlbumName = album.NAME,
                            Tracks = new List<TrackModel>()
                        };

                        foreach (var track in album.SPRW_TRACK)
                        {
                            var trackModel = new TrackModel
                            {
                                TrackId = track.TRACK_ID,
                                TrackName = track.NAME
                            };
                            albumModel.Tracks.Add(trackModel);
                        }
                        model.Add(albumModel);
                    }
                }

                return model;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int CreateAlbum(ModifyAlbumModel model)
        {
            try
            {
                using (var context = new SparrowMusicEntities())
                {
                    var album = new SPRW_ALBUM()
                    {
                        ARTIST_ID = model.ArtistId,
                        RELEASE_DATE = model.ReleaseDate,
                        NAME = model.AlbumName,
                        DESCRP = model.Description,
                        LAST_MAINT_USER_ID = "",
                        LAST_MAINT_TIME = DateTime.Now
                    };
                    context.SPRW_ALBUM.Add(album);
                    context.SaveChanges();

                    return album.ALBUM_ID;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void UpdateAlbum(ModifyAlbumModel model)

        //public int CreateAlbumImage(CreateAlbumImageModel model)
        //{
        //    try
        //    {
        //        using (var context = new SparrowMusicEntities())
        //        {
        //            var albumImage = new SPRW_ALBUM_IMG
        //            {
        //                ACT_IND = true,
        //                ALBUM_ID = model.AlbumId,
        //                DESCRP = model.Description,
        //                LAST_MAINT_TIME = DateTime.Now,
        //                LAST_MAINT_USER_ID = model.UserId
        //            };
        //            context.SPRW_ALBUM_IMG.Add(albumImage);
        //            context.SaveChanges();

        //            return albumImage.IMG_ID;
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //}

        //public int GetArtistId(int albumId)
        //{
        //    try
        //    {
        //        using (var context = new SparrowMusicEntities())
        //        {
        //            return context.SPRW_ALBUM.FirstOrDefault(i => i.ALBUM_ID == albumId).ARTIST_ID;
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //}

        //public StatusModel DeleteAlbum(int id)
        //{
        //    var messages = new List<string>();
        //    var status = new StatusModel
        //    {
        //        Success = true
        //    };

        //    try
        //    {
        //        using (var context = new SparrowMusicEntities())
        //        {
        //            var album = context.SPRW_ALBUM.FirstOrDefault(i => i.ALBUM_ID == id);
        //            context.SPRW_ALBUM.Remove(album);
        //            context.SaveChanges();
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        status.Success = false;
        //        messages.Add("Exception: " + e);
        //    }

        //    status.Messages = messages;
        //    return status;
        //}

        //public void DeleteAlbumImage(int id)
        //{
        //    try
        //    {
        //        using (var context = new SparrowMusicEntities())
        //        {
        //            var album = context.SPRW_ALBUM_IMG.FirstOrDefault(i => i.IMG_ID == id);
        //            context.SPRW_ALBUM_IMG.Remove(album);
        //            context.SaveChanges();
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //}
    }
}
