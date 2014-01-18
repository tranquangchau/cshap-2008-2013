define(function() {


//	========================================================================================
//										CONFIG
//	========================================================================================


	return {
		
		/**
			--------------------------------------------------------------------------------
				NAVIGATION CONTROLLERS
				Settings of the navigation modes: 
					- keyboard
					- arrow buttons
					- dots buttons
			--------------------------------------------------------------------------------
		*/
		
		controllers: {
		
			// KEYBOARD NAVIGATION
			// ----------------------------
			
			keyboard: {
				
				// Enable/Disable the keyboard navigation
				// [true, false]
				enable:	true
			
			},
			
			// ARROWS NAVIGATION
			// ----------------------------
			
			arrows: {
				
				// Enable/Disable the arrows navigation
				// [true, false]
				enable:	true
				
				// Enable/Disable the ability to hide themselves if the window is too small
				// [true, false]
			,	visibilityControl: true
				
				// Arrows position on the window sides
				// [top, center, bottom]	
			,	position: 'center'
				
				// Arrows Width	
				// *number*
			,	width: 37
				
				// Arrows Height	
				// *number*	
			,	height: 73
				
				// Margin from the window side
				// *number*
			,	marginWindow: 30
				
			},
			
			// DOT BUTTONS NAVIGATION
			// ----------------------------
			
			dots: {
			
				sections: {
					
					// Enable/Disable buttons for sections
					// [true, false]
					enable: true
					
					// Enable/Disable the ability to hide themselves if the window is too small
					// [true, false]
				,	visibilityControl: true
				
					// Dots position on window sides
					// [topleft, centerleft, bottomleft, topright, centerright, bottomright]	
				,	position: 'bottomleft'
					
					// Width and Height of the dots
					// *number*
				,	side: 17
					
					// Margin between dots
					// *number*
				,	margin: 5
					
					// Margin from the window side
					// *number*
				,	marginWindow: 10
					
				},
				
				pages: {
					
					// Enable/Disable dot buttons for pages
					// [true, false]
					enable: true
				
					// Dots position on window sides
					// [topleft, topcenter, topright, bottomleft, bottomcenter, bottomright]	
				,	position: 'bottomcenter'
					
					// Width and Height of the dots
					// *number*
				,	side: 15
					
					// Margin between dots
					// *number*
				,	margin: 5
					
					// Margin from the window side
					// *number*
				,	marginWindow: 10
					
				}
			
			}			
		
		},
		
		/**
			--------------------------------------------------------------------------------
				BAR
				Bar is a fixed element always visible on the window sides.
			--------------------------------------------------------------------------------
		*/
		
		bar: {
		
			// Bar position on the window sides
			// [top, right, bottom, left]	
			position: 'top'
		
		},
		
		/**
			--------------------------------------------------------------------------------
				PAGES SETTINGS
				Page is the final element of the FSN structure,
				it is the element that will contain the content visible to the final user.
			--------------------------------------------------------------------------------
		*/
		
		pages: {
			
			// Page body width in pixel, 0 to set width 100%
			// *number*
			width: 980
			
			// Page body alignment relative to the page
			// [left, center, right]
		,	alignment: 'center'
			
			// Top and bottom margin between the page and the page body
			// *number*
		,	margin: 60
			
			// Enable/Disable the page scroll
			// [true, false]
		,	scrollPage: true
			
			// Speed of the page transition
			// *number*
		,	speed: 500
			
			// Animation easing of the page transition
			// [jswing, def, easeInQuad, easeOutQuad, easeInOutQuad, easeInCubic, easeOutCubic, 
			// easeInOutCubic, easeInQuart, easeOutQuart, easeInOutQuart, easeInQuint, easeOutQuint, 
			// easeInOutQuint, easeInSine, easeOutSine, easeInOutSine, easeInExpo, easeOutExpo, easeInOutExpo, 
			// easeInCirc, easeOutCirc, easeInOutCirc, easeInElastic, easeOutElastic, easeInOutElastic, 
			// easeInBack, easeOutBack, easeInOutBack, easeInBounce, easeOutBounce, easeInOutBounce]
		,	easing: 'easeInQuart'
			
			// Ajax loader color
			// ['white', 'black']
		,	loader: 'white'
			
		,	animationBody: {
				
				// Enable/Disable the page body transition
				// [true, false]
				enable: true
				
				// Shift of the page body transition
				// *number*
			,	shift: 35
				
				// Delay of the page body transition relative to the page transition speed
				// *number*
			,	delay: 700
			
				// Animation easing of the page body transition	
				// [jswing, def, easeInQuad, easeOutQuad, easeInOutQuad, easeInCubic, easeOutCubic, 
				// easeInOutCubic, easeInQuart, easeOutQuart, easeInOutQuart, easeInQuint, easeOutQuint, 
				// easeInOutQuint, easeInSine, easeOutSine, easeInOutSine, easeInExpo, easeOutExpo, easeInOutExpo, 
				// easeInCirc, easeOutCirc, easeInOutCirc, easeInElastic, easeOutElastic, easeInOutElastic, 
				// easeInBack, easeOutBack, easeInOutBack, easeInBounce, easeOutBounce, easeInOutBounce]
			,	easing: 'easeOutQuart'
			
			}
			
		},
		
		/**
			--------------------------------------------------------------------------------
				SCROLLBAR SETTINGS
				Settings of the Scrollbar
			--------------------------------------------------------------------------------
		*/
		
		scrollbar: {
		
			// TRACK
			// ----------------------------
			
			track: {
				
				// Total scrollbar width
				// *number*
				width: 14
				
				// Padding between track and cursor
				// *number*
			,	padding: 3
				
				// Margin between content and scrollbar
				// *number*
			,	margin: 15
				
				// Track background color
				// *hex color*
			,	background: 'none'
				
				// Radius for rounded corners
				// *number*
			,	borderRadius: 0
				
			},
			
			// CURSOR
			// ----------------------------
			
			cursor: {
				
				// Cursor background color
				// *hex color*
				background: '#fff'
				
				// Cursor border width
				// *number*
			,	borderWidth: 0
				
				// Cursor border color
				// *hex color*
			,	borderColor: '#fff'
				
				// Radius for rounded corners
				// *number*
			,	borderRadius: 4
				
				// Cursor opacity
				// [0-1]
			,	opacity: 0.45
				
			}	
		
		},
		
		/**
			--------------------------------------------------------------------------------
				ALERT IE6
				FSN warns the IE6 users that their browser is obsolete and recommends 
				them to update it to enjoy the best browsing experience.
			--------------------------------------------------------------------------------
		*/
		
		ie6Alert: {
		
			// Enable/Disable IE6 Alert
			// [true, false]
			enable: true
		
		}
	
	}
	
});