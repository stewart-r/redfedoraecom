"use strict";

var _app = require("./app");

var _gridViewCell = require("./products/gridViewCell");

_app.app.controller("gridCellCtrl", _gridViewCell.GridCellCtrl.Factory);

_app.app.directive("gridCell", function () {
  return _gridViewCell.GridCellDirective.GetInstance();
});
//# sourceMappingURL=index.js.map