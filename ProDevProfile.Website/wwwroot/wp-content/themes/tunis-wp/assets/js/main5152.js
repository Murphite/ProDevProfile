(function ($) {
    "use strict";


	$('.cs_preloader').delay(150).fadeOut('slow');

	  jQuery(window).on('load', function() {
		// init Masonry
		var $grid = $('.grid,.wbarchivess ul.products').masonry({
			// options
			itemSelector: '.grid-item,#single-products',
		});
		// layout Masonry after each image loads
		$grid.imagesLoaded().progress( function() {
			$grid.masonry('layout');
		});
	});


})(jQuery);
