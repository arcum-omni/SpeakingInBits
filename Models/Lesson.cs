using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpeakingInBits.Models
{
    /// <summary>
    /// A generic course lesson
    /// </summary>
    public abstract class Lesson
    {
        [Key]
        public int LessonID { get; set; }

        [Required]
        public string LessonTitle { get; set; }

        public string LessonDescription { get; set; }
    }

    /// <summary>
    /// Video Lecture Lesson
    /// </summary>
    public class VideoLesson : Lesson
    {
        /// <summary>
        /// Embed Code for Video,
        /// IE YouTube, Vimeo, etc.
        /// </summary>
        public string EmbedCode { get; set; }
    }
}