# WOWS-Model-Tool

**修改自Lotsbiss的WOT模型替换。因原作者不允许公开分享原版工具（芝士条说的），原则上此工具也不对外分享。**

## 下载
请到[release](https://github.com/SEA-group/WoT-Model-Tool-WoWS-Refit/releases)中寻找最新版本

## 更新日志

### 2020.12.09a
* 更换了更现代的logo（

### 2020.11.03a
* 重写了计算tangent与binormal的方法以适应有平滑处理过的网格。影响不明显。

### 2020.09.15b
* 添加了logo

### 2020.09.15a
* 添加了对xyznuviiiww顶点类型的支持（带骨骼的半透明模型）。

### 2020.07.14b
* 尝试修复了list32分段不能二次编辑的问题，简单测试后暂认为该问题得到了解决，但是我总觉得哪里还有点不对。
* **但是，使用07.14a版编辑过list32分段的primitives文件，在07.14b版中依然不能读取。也就是说前一版本的修改依然是一次性的**

### 2020.07.14a
* 添加了对list32三角形类型的支持（即分段顶点数超过65535的模型）。
* **已知bug：list32类型的模型分段只能替换一次，之后无法再用该工具读取（尽管游戏里用着没什么问题（可以考虑用作防止二次编辑的手段**

### 2020.06.27
* 添加对xyznuvr顶点类型的支持（缆线模型的顶点类型）。
* 添加对xyznuv顶点类型的uv支持（现在拆出来的舰桥玻璃的模型也有正确的uv了）。
