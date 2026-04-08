# Research

## Key INfo
Author: GordenJ
Community lead: johnsanc (good egg)

Feature Reqs: https://romvault.convas.io/requests
There is a discord Channel


## Controls

### Context Menus
|Function|Control Name|File/Class Location|Notes|
|-|-|-|
|Game Grid|_mnuGameGrid |FrmMain_GameGrid.cs/FrmMain||
|Dat Grid|_mnuContext<br>_mnuContextToSort|FrmMain_DatGrid.cs/FrmMain|Two cms, but not sure when each is opened|

### DatTree
To access the Tree from FrmMain, use `ctrRvTree`
Also, `_clickedTree` may be helpfull for UIOps
Tree holds:
```csharp
private RvFile _lTree;
```
RvFiles can have child RVFiles (hierarchical)
Have created new Property:
```csharp
RvTree.ChildFiles
```
for easy access. Other methods that are publicly available:
```cs
// Expands/Collapses specified node/page
.SetExpanded(rootDatNode,
            rightClick: ((Control.ModifierKeys & Keys.Shift) == Keys.Shift),
            isWorking: _working);
```

```
// Refreshes the tree to update icons
.SetupInt();
```