


$(document).ready(function () {
    $('.removeAccount').on('click', function () {
        if (confirm('Are you sure you want to remove this account?  This action cannot be undone.')) {
            $(this).closest('.account-wrapper').remove();
        }
    });
    $('.detailsBar').on('click', function () {
        ToggleTransferDetails($(this));
    });
    $('#addNewExternalAccount').on('click', function () {

    });
});

function ToggleTransferDetails($bar)
{
    
    var $transferDetails = $bar.closest('.account-wrapper').find('.transferDetails');
    if ($bar.attr('data-collapsed') == 'true') {
        $transferDetails.slideDown(300, 'linear',
            function () {
                $bar.attr('data-collapsed', 'false');
                $bar.find('span.glyphicon-menu-down').removeClass('glyphicon-menu-down').addClass('glyphicon-menu-up');
            }); 
    }
    else {
        $transferDetails.slideUp(300, 'linear', function () {
            $bar.attr('data-collapsed', 'true');
            $bar.find('span.glyphicon-menu-up').removeClass('glyphicon-menu-up').addClass('glyphicon-menu-down');
        });
    }
}