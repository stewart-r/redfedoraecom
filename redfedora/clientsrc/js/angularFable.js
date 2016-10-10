"use strict";

exports.__esModule = true;
exports.NgFable = undefined;

var _createClass = function () { function defineProperties(target, props) { for (var i = 0; i < props.length; i++) { var descriptor = props[i]; descriptor.enumerable = descriptor.enumerable || false; descriptor.configurable = true; if ("value" in descriptor) descriptor.writable = true; Object.defineProperty(target, descriptor.key, descriptor); } } return function (Constructor, protoProps, staticProps) { if (protoProps) defineProperties(Constructor.prototype, protoProps); if (staticProps) defineProperties(Constructor, staticProps); return Constructor; }; }();

var _fableCore = require("fable-core");

function _classCallCheck(instance, Constructor) { if (!(instance instanceof Constructor)) { throw new TypeError("Cannot call a class as a function"); } }

var NgFable = exports.NgFable = function ($exports) {
    var NgModelMap = $exports.NgModelMap = function () {
        function NgModelMap(mapType) {
            _classCallCheck(this, NgModelMap);

            this.mapType = mapType;
        }

        _createClass(NgModelMap, [{
            key: "ngModel",
            get: function get() {
                return this.mapType;
            }
        }]);

        return NgModelMap;
    }();

    _fableCore.Util.setInterfaces(NgModelMap.prototype, [], "AngularFable.NgFable.NgModelMap");

    return $exports;
}({});
//# sourceMappingURL=angularFable.js.map