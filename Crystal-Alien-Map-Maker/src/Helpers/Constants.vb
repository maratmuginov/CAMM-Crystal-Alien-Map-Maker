﻿Public Module Constants

#If DEBUG Then
    Public Const BuildType As String = "[Debug]"
    Public Const DataDir As String = "/../../../CAMM_Data"
    Public Const SaveDir As String = "/../../../Maps"
#Else
    Public Const BuildType As String = "[Stable]"
    Public Const DataDir As String = "/CAMM_Data"
    Public Const SaveDir As String = "/Maps"
#End If

    Public ReadOnly AppPath As String = My.Application.Info.DirectoryPath
    Public ReadOnly DataPath As String = AppPath + DataDir
    Public ReadOnly SavePath As String = AppPath + SaveDir
    Public Const ConfigFileName As String = "Config.json"
    Public ReadOnly ConfigFile As String = DataPath + "/" + ConfigFileName
    Public ReadOnly RectangleBrushPath As String = DataPath + "/Brushes/Rectangle"
    Public ReadOnly DefaultMapsPath As String = DataPath + "/Default_Maps"
    Public ReadOnly AboutMenuMapPath As String = DataPath + "/AboutMenuMap.camm"

    Public Const CACPlayerAppName = "CAC Player"
    Public ReadOnly CACPlayerPath_Windows1 As String = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "/" + CACPlayerAppName + "/" + CACPlayerAppName + ".exe"
    Public ReadOnly CACPlayerPath_Windows2 As String = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "/" + CACPlayerAppName + "/" + CACPlayerAppName + ".exe"
    Public Const CACPlayerPath_MacOS As String = "/Applications/" + CACPlayerAppName + ".app"

    Public Const ConfigFormat As Integer = 11
    Public Const MapFormat As Integer = 8
    Public Const BaseJsonMapFormat As Integer = 7

    Public Const TileSizeX As Integer = 96
    Public Const TileSizeY As Integer = 48

    'TODO: Externalize to config file.
    Public Const CashPlayerDefault = 2000
    Public Const CashEnemyDefault = 20000
    Public Const IsTrainingDefault As Boolean = False
    Public Const IsConflictDefault As Boolean = False
    Public Const IsSpecialLevelDefault As Boolean = False
    Public Const IsLastSpecialLevelDefault As Boolean = False
    Public Const IsBonusLevelDefault As Boolean = True

    'TODO: Externalize to config file.
    Public ReadOnly PenTileHover As Pen = New Pen(Pens.DarkOrange.Brush, 2)
    Public ReadOnly PenTileErase As Pen = New Pen(Pens.Red.Brush, 2)
    Public ReadOnly PenGrid As Pen = Pens.Black
    Public ReadOnly PenSelectionHover As Pen = New Pen(Pens.DarkOrange.Brush, 2)
    Public ReadOnly PenSelected As Pen = New Pen(Pens.LimeGreen.Brush, 3)
    Public ReadOnly BrushBuildingPlacement As SolidBrush = New SolidBrush(Color.FromArgb(128, 0, 255, 0))
    Public ReadOnly BrushBuildingSelectionHover As SolidBrush = New SolidBrush(Color.FromArgb(128, 255, 255, 255))
    Public ReadOnly BrushBuildingSelected As SolidBrush = New SolidBrush(Color.FromArgb(128, 142, 255, 255))

    Public Enum ToolMode
        Pointer
        Brush
        SmartBrush
        RectangleBrush
        Eraser
    End Enum

    Public Enum Team
        Unknown = -1
        Astros = 0
        Aliens = 1
        Neutral = 2
    End Enum

End Module
