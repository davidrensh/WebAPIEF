var ViewModel1 = function () {
    var self = this;
    self.error = ko.observable();
    self.activities = ko.observableArray();
    var activitiesUri = '/api/activities/';

    function ajaxHelper(uri, method, data) {
        self.error(''); // Clear error message
        return $.ajax({
            type: method,
            url: uri,
            dataType: 'json',
            contentType: 'application/json',
            data: data ? JSON.stringify(data) : null
        }).fail(function (jqXHR, textStatus, errorThrown) {
            self.error(errorThrown);
        });
    }

    function getAllActivities() {
        ajaxHelper(activitiesUri, 'GET').done(function (data) {
            self.activities(data);
        });
    }

    // Fetch the initial data.

    getAllActivities();

};

ko.applyBindings(new ViewModel1());
