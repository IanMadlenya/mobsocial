﻿app.service("likeService", ["globalApiEndPoint", "webClientService", function (globalApiEndPoint, webClientService) {
    var apiEndPoint = globalApiEndPoint + "/customerlike";
    this.Like = function (type, id, success, error) {
        webClientService.post(apiEndPoint + "/like/" + type + "/" + id, null, success, error);
    };

    this.Unlike = function (type, id, success, error) {
        webClientService.post(apiEndPoint + "/unlike/" + type + "/" + id, null, success, error);
    };

}]);
