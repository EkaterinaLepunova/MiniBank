Type.registerNamespace('ns');

ns.AnchorChanger.prototype = function() {
    this.init();
};

ns.AnchorChanger.prototype.config = {
    colors: ["#345", "#ADD", "#3FF"]
};

ns.AnchorChanger.prototype.changeColor = function(obj, newColor) {
    obj.style.backgroundColor = newColor;
};

ns.AnchorChanger.prototype.init = function() {
    var self = this;
    var anchors = document.getElementsByTagName("a");
    var size = anchors.length;
    for (var i = 0; i < size; i++) {
        anchors[i].color = self.config.colors[i];
        anchors[i].onclick = function () {
            self.changeColor(this, this.color);
            return false;
        };
    }
    
};

// Register this class
ns.AnchorChanger.registerClass("ns.AnchorChanger");
Sys.Application.notifyScriptLoaded();
