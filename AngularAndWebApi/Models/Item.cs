using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Mvc;

namespace AngularAndWebApi.Models
{
    /// <summary>
    /// Item
    /// </summary>
    public class Item : INotifyPropertyChanged
    {
        private string _name;
        private string _type;

        /// <summary>
        /// Uniq identifier
        /// </summary>
        [HiddenInput]
        public int Id { get; set; }

        /// <summary>
        /// Name of item
        /// </summary>
        [Required]
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        /// <summary>
        /// Type of item
        /// </summary>
        [Required]
        public string Type
        {
            get { return _type; }
            set
            {
                _type = value;
                OnPropertyChanged("Type");
            }
        }

        /// <inheritdoc />
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Changing property
        /// </summary>
        /// <param name="propertyName">Name of property</param>
        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}