"use strict";

exports.__esModule = true;
exports.Product = undefined;

var _createClass = function () { function defineProperties(target, props) { for (var i = 0; i < props.length; i++) { var descriptor = props[i]; descriptor.enumerable = descriptor.enumerable || false; descriptor.configurable = true; if ("value" in descriptor) descriptor.writable = true; Object.defineProperty(target, descriptor.key, descriptor); } } return function (Constructor, protoProps, staticProps) { if (protoProps) defineProperties(Constructor.prototype, protoProps); if (staticProps) defineProperties(Constructor, staticProps); return Constructor; }; }();

var _fableCore = require("fable-core");

function _classCallCheck(instance, Constructor) { if (!(instance instanceof Constructor)) { throw new TypeError("Cannot call a class as a function"); } }

var Product = exports.Product = function () {
    function Product(title, desc) {
        _classCallCheck(this, Product);

        this.title = title;
        this.desc = desc;
    }

    _createClass(Product, [{
        key: "Title",
        get: function get() {
            return this.title;
        }
    }, {
        key: "Description",
        get: function get() {
            return this.desc;
        }
    }]);

    return Product;
}();

_fableCore.Util.setInterfaces(Product.prototype, [], "Product.Product");
//# sourceMappingURL=product.js.map