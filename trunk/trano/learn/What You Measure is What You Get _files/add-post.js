
/**
 *		add-post.js
 *
 *		Ajax add Community News
 *
 *		@version 2.0
 */


jQuery(document).ready( function($) {
	
	$('#fvcn-add-post').submit(function() {
		$('#fvcn-form-message').addClass('fvcn-loading');
		$('#fvcn-form-message').text('Loading...');
		
		$('#fvcn-ajax').val('true');
		var url = $('#fvcn-current-location').val();
		var data = $('#fvcn-add-post').serialize();
		
		$.ajax({
			type: 'POST',
			url: url,
			data: data,
			success: function(data) {
				$('fvcn-add-post', data).each(function() {
					
					var message = $('fvcn-response > message', this).text();
					$('#fvcn-form-message').removeClass('fvcn-loading');
					
					if ('false' == $('fvcn-response > success', this).text()) {
						$('.fvcn-error').remove();
						
						if ('' != $('fvcn-author > error', this).text()) {
							$('#fvcn-author').parent().append('<ul class="fvcn-error"><li>' + $('fvcn-author > error', this).text() + '</li></ul>');
						}
						if ('' != $('fvcn-author-email > error', this).text()) {
							$('#fvcn-author-email').parent().append('<ul class="fvcn-error"><li>' + $('fvcn-author-email > error', this).text() + '</li></ul>');
						}
						if ('' != $('fvcn-url > error', this).text()) {
							$('#fvcn-url').parent().append('<ul class="fvcn-error"><li>' + $('fvcn-url > error', this).text() + '</li></ul>');
						}
						if ('' != $('fvcn-title > error', this).text()) {
							$('#fvcn-title').parent().append('<ul class="fvcn-error"><li>' + $('fvcn-title > error', this).text() + '</li></ul>');
						}
						if ('' != $('fvcn-content > error', this).text()) {
							$('#fvcn-content').parent().append('<ul class="fvcn-error"><li>' + $('fvcn-content > error', this).text() + '</li></ul>');
						}
						
						$('#fvcn-form-message').text( message );
					} else {
						$('#fvcn-add-post').slideUp('slow');
						$('#fvcn-form-message').text( message );
					}
					
				});
			},
			error: function() {
				$('#fvcn-form-message').removeClass('fvcn-loading');
				$('#fvcn-form-message').text('An error occured while processing your request, please try again later.');
			}
		});
		
		return false;
	});
	
});
