// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function addCommas(nStr) {
	nStr += '';
	x = nStr.split('.');
	x1 = x[0];
	x2 = x.length > 1 ? '.' + x[1] : '';
	var rgx = /(\d+)(\d{3})/;
	while (rgx.test(x1)) {
		x1 = x1.replace(rgx, '$1' + ',' + '$2');
	}
	return x1 + x2;
}

$(document).ready(function () {
	$('#myTable').DataTable();
});


$('.multiple-items').slick({
	arrows: true,
	infinite: true,
	slidesToShow: 2,
	slidesToScroll: 1
});


$("#editCurrentMortgage").click(function () {
    $.get('@Url.Action("EditCurrentMortgage","Customers")', {}, function (response) {
        $("#Display").html(response);
    });
});

(function ($) {
    var handler = Plaid.create({
        clientName: 'Plaid Quickstart',
        // Optional, specify an array of ISO-3166-1 alpha-2 country
        // codes to initialize Link; European countries will have GDPR
        // consent panel
        countryCodes: ['US'],
        env: 'sandbox',
        // Replace with your public_key from the Dashboard
        key: '',
        product: ['liabilities'],
        // Optional, use webhooks to get transaction and error updates
        webhook: 'https://requestb.in',
        // Optional, specify a language to localize Link
        language: 'en',
        // Optional, specify userLegalName and userEmailAddress to
        // enable all Auth features
        userLegalName: 'John Appleseed',
        userEmailAddress: 'jappleseed@yourapp.com',
        onLoad: function () {
            // Optional, called when Link loads
        },
        onSuccess: function (public_token, metadata) {
            // Send the public_token to your app server.
            // The metadata object contains info about the institution the
            // user selected and the account ID or IDs, if the
            // Select Account view is enabled.
            $.post('/get_access_token', {
                public_token: public_token,
            });
        },
        onExit: function (err, metadata) {
            // The user exited the Link flow.
            if (err != null) {
                // The user encountered a Plaid API error prior to exiting.
            }
            // metadata contains information about the institution
            // that the user selected and the most recent API request IDs.
            // Storing this information can be helpful for support.
        },
        onEvent: function (eventName, metadata) {
            // Optionally capture Link flow events, streamed through
            // this callback as your users connect an Item to Plaid.
            // For example:
            // eventName = "TRANSITION_VIEW"
            // metadata  = {
            //   link_session_id: "123-abc",
            //   mfa_type:        "questions",
            //   timestamp:       "2017-09-14T14:42:19.350Z",
            //   view_name:       "MFA",
            // }
        }
    });

    $('#link-button').on('click', function (e) {
        handler.open();
    });
})(jQuery);
