﻿using EssentialUIKit.DataService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace EssentialUIKit.Views.Navigation
{
    [Preserve(AllMembers =true)]
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PhotosPage : ContentPage
	{
		public PhotosPage ()
		{
			InitializeComponent ();

            this.BindingContext = PhotosDataService.Instance.PhotosViewModel;
		}
	}
}