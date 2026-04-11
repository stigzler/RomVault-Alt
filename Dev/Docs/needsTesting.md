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

## Import DATs function
Need to check that the "Import DAT to this Directory" puts the dats in the 'right place' - seems OK prima facie but are there any edge cases that break the system? E.g. Dir DAT settings?

## Terminology Changes

These make more sense to me as a new user, but again are there edge cases where the semantics would break?

|UI Item|Default|CHnaged To|Rationale and Notes|
|-|-|-|
|DatContextMenu|Set Dir Mappings|Set ROM Folder|As a new user, just makes more sense to link the dat to the concept of a rom folder rather than a "mapping" (use concrete noun rather than abstraction/action based|
|DatContextMenu|Scan|Scan ROMs|I Think I don't understand why this is here. I could understand "Scan for Fixes", but not he less this does call the ScanRoms function, so specifics relayed about what Scan this will do ("Scan" is vague - could be rom scna, dat scan, or fix scan). Again, verbs and nouns|
|DatContextMenu|Open Directory|Open Roms Folder|Again, I may be missing an edge case, but verb/noun pairing better. Defulat leaves user thinking "is it opening the dat folder, the roms folder or the ToSort folder?|
|ToSortContextMenu|Scan|Scan ROM files|Again - verb/noun clearer|
|DATInfoBox|Path|Rom Path|Users may miss the heading. Re-iteration.|


**Postscript:** On top of the above - changed all references from "Directory" to "Folder"

## Rom Directories
In `FrmDirectoryMappings` it stored paths relative to the Application root dir. I changed this to store the full path. Users can see the root path in the dat's rompath path and relative paths looked very messy. so before change they would see:

`..\..\..\..\..\..\..\..\..\..\temp\project tests\RomVaultRevamp\testRomsRoot\Test 2\Atari - Atari 5200`

and after change:

`C:\temp\project tests\RomVaultRevamp\testRomsRoot\Test 2\Atari - Atari 5200`

A lot less messy. Regarding the business logic, the final path seems to get stored as 

`DirMapping.Dir`

Tests for Scan for Fixes and Fix:
(success = roms moved into rom directory for dat)

|Path Type|Example|Result|Notes
|-|-|-|-|
|Local System Drive|C:\temp\project tests\RomVaultRevamp\testRomsRoot|Success||
|Local Other Drive|D:\RomRoot|Success
|Network|\\HomeServer\Media\Games\test-roms|Success

Also, couldn't follow the datagridview row color key, so just replaced a couple of conditions with making the text the form color (with no background color) . Marked the two case with:

`// wasn't sure what to put here`

