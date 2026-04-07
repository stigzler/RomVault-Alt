# Needs Testing

## ToSort Context Menu

Dynamic menu. The 4 menu items below has visibility toggled depending on some status. However, cms is initiated with all 4 visible in FrmMain ~342.

            _mnuContextToSort.Items.Add(_mnuToSortSetPrimary);
            _mnuContextToSort.Items.Add(_mnuToSortSetCache);
            _mnuContextToSort.Items.Add(_mnuToSortSetFileOnly);
            _mnuContextToSort.Items.Add(_mnuToSortClearFileOnly);



However, `DirTreeRvSelected` then toggles both the visibility *and* re-adds them for some reason in the original code. I removed the re-adds, and seems to work but don't understand the systems well enough to make sure i haven't broken anything. You can set each folder to:
- File ONly
- Primary
- Cache

And setting one effects the others. Need someone who understands these systems to make sure that removing the re-addition of these menu items doesn't break functionality (can't see why it would)


## Folder Lock Function

The rvTree Control is baffling. Managed to toggle Lock on from MainFrm:

```cs
private void ToSortLock(object sender, EventArgs e)
{
    _clickedTree.Tree.SetChecked(RvTreeRow.TreeSelect.Locked, true);
    ctrRvTree.Refresh();
}
```

Just not sure if this updates any necessary vars as well and not just updates the UI. 
