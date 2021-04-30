<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.tvTreeView = New System.Windows.Forms.TreeView()
        Me.imgTVList = New System.Windows.Forms.ImageList(Me.components)
        Me.lvListView = New System.Windows.Forms.ListView()
        Me.imgTVListB = New System.Windows.Forms.ImageList(Me.components)
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblCompany = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.picListView = New System.Windows.Forms.PictureBox()
        Me.picTitles = New System.Windows.Forms.PictureBox()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        CType(Me.picListView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTitles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tvTreeView
        '
        Me.tvTreeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tvTreeView.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvTreeView.ImageIndex = 0
        Me.tvTreeView.ImageList = Me.imgTVList
        Me.tvTreeView.Location = New System.Drawing.Point(0, 125)
        Me.tvTreeView.Name = "tvTreeView"
        Me.tvTreeView.SelectedImageIndex = 0
        Me.tvTreeView.Size = New System.Drawing.Size(217, 239)
        Me.tvTreeView.TabIndex = 11
        '
        'imgTVList
        '
        Me.imgTVList.ImageStream = CType(resources.GetObject("imgTVList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgTVList.TransparentColor = System.Drawing.Color.Transparent
        Me.imgTVList.Images.SetKeyName(0, "add.png")
        Me.imgTVList.Images.SetKeyName(1, "address_book.png")
        Me.imgTVList.Images.SetKeyName(2, "administrator.png")
        Me.imgTVList.Images.SetKeyName(3, "arrow_down.png")
        Me.imgTVList.Images.SetKeyName(4, "arrow_down2.png")
        Me.imgTVList.Images.SetKeyName(5, "arrow_left.png")
        Me.imgTVList.Images.SetKeyName(6, "arrow_left2.png")
        Me.imgTVList.Images.SetKeyName(7, "arrow_right.png")
        Me.imgTVList.Images.SetKeyName(8, "arrow_right2.png")
        Me.imgTVList.Images.SetKeyName(9, "arrow_up.png")
        Me.imgTVList.Images.SetKeyName(10, "arrow_up2.png")
        Me.imgTVList.Images.SetKeyName(11, "attachment.png")
        Me.imgTVList.Images.SetKeyName(12, "audio_volume_high.png")
        Me.imgTVList.Images.SetKeyName(13, "audio_volume_low.png")
        Me.imgTVList.Images.SetKeyName(14, "audio_volume_medium.png")
        Me.imgTVList.Images.SetKeyName(15, "audio_volume_mute.png")
        Me.imgTVList.Images.SetKeyName(16, "audio_volume_none.png")
        Me.imgTVList.Images.SetKeyName(17, "binoculars.png")
        Me.imgTVList.Images.SetKeyName(18, "binoculars2.png")
        Me.imgTVList.Images.SetKeyName(19, "book.png")
        Me.imgTVList.Images.SetKeyName(20, "bookmark.png")
        Me.imgTVList.Images.SetKeyName(21, "briefcase.png")
        Me.imgTVList.Images.SetKeyName(22, "calculator.png")
        Me.imgTVList.Images.SetKeyName(23, "calendar.png")
        Me.imgTVList.Images.SetKeyName(24, "camera.png")
        Me.imgTVList.Images.SetKeyName(25, "cancel.png")
        Me.imgTVList.Images.SetKeyName(26, "chat.png")
        Me.imgTVList.Images.SetKeyName(27, "chat_exclamation.png")
        Me.imgTVList.Images.SetKeyName(28, "checkbox_check.png")
        Me.imgTVList.Images.SetKeyName(29, "checkbox_cross.png")
        Me.imgTVList.Images.SetKeyName(30, "checkbox_empty.png")
        Me.imgTVList.Images.SetKeyName(31, "checkbox_round.png")
        Me.imgTVList.Images.SetKeyName(32, "checkmark.png")
        Me.imgTVList.Images.SetKeyName(33, "clip.png")
        Me.imgTVList.Images.SetKeyName(34, "clipboard.png")
        Me.imgTVList.Images.SetKeyName(35, "clock.png")
        Me.imgTVList.Images.SetKeyName(36, "close.png")
        Me.imgTVList.Images.SetKeyName(37, "copy.png")
        Me.imgTVList.Images.SetKeyName(38, "copy2.png")
        Me.imgTVList.Images.SetKeyName(39, "couple.png")
        Me.imgTVList.Images.SetKeyName(40, "cross.png")
        Me.imgTVList.Images.SetKeyName(41, "delete.png")
        Me.imgTVList.Images.SetKeyName(42, "diary.png")
        Me.imgTVList.Images.SetKeyName(43, "diskette.png")
        Me.imgTVList.Images.SetKeyName(44, "document.png")
        Me.imgTVList.Images.SetKeyName(45, "door.png")
        Me.imgTVList.Images.SetKeyName(46, "download.png")
        Me.imgTVList.Images.SetKeyName(47, "download2.png")
        Me.imgTVList.Images.SetKeyName(48, "download3.png")
        Me.imgTVList.Images.SetKeyName(49, "edit.png")
        Me.imgTVList.Images.SetKeyName(50, "envelope.png")
        Me.imgTVList.Images.SetKeyName(51, "envelope_open.png")
        Me.imgTVList.Images.SetKeyName(52, "external_link.png")
        Me.imgTVList.Images.SetKeyName(53, "file.png")
        Me.imgTVList.Images.SetKeyName(54, "folder.png")
        Me.imgTVList.Images.SetKeyName(55, "games_control.png")
        Me.imgTVList.Images.SetKeyName(56, "games_deck_clubs.png")
        Me.imgTVList.Images.SetKeyName(57, "games_deck_diamonds.png")
        Me.imgTVList.Images.SetKeyName(58, "games_deck_hearts.png")
        Me.imgTVList.Images.SetKeyName(59, "games_deck_spades.png")
        Me.imgTVList.Images.SetKeyName(60, "games_dice.png")
        Me.imgTVList.Images.SetKeyName(61, "gear.png")
        Me.imgTVList.Images.SetKeyName(62, "group.png")
        Me.imgTVList.Images.SetKeyName(63, "hand_point.png")
        Me.imgTVList.Images.SetKeyName(64, "hand_share.png")
        Me.imgTVList.Images.SetKeyName(65, "hand_thumbsdown.png")
        Me.imgTVList.Images.SetKeyName(66, "hand_thumbsup.png")
        Me.imgTVList.Images.SetKeyName(67, "help.png")
        Me.imgTVList.Images.SetKeyName(68, "history.png")
        Me.imgTVList.Images.SetKeyName(69, "history2.png")
        Me.imgTVList.Images.SetKeyName(70, "history3.png")
        Me.imgTVList.Images.SetKeyName(71, "home.png")
        Me.imgTVList.Images.SetKeyName(72, "hourglass.png")
        Me.imgTVList.Images.SetKeyName(73, "info.png")
        Me.imgTVList.Images.SetKeyName(74, "inventory.png")
        Me.imgTVList.Images.SetKeyName(75, "lightbulb.png")
        Me.imgTVList.Images.SetKeyName(76, "list.png")
        Me.imgTVList.Images.SetKeyName(77, "lock_closed.png")
        Me.imgTVList.Images.SetKeyName(78, "lock_open.png")
        Me.imgTVList.Images.SetKeyName(79, "menu_bars.png")
        Me.imgTVList.Images.SetKeyName(80, "microphone.png")
        Me.imgTVList.Images.SetKeyName(81, "monitor.png")
        Me.imgTVList.Images.SetKeyName(82, "more.png")
        Me.imgTVList.Images.SetKeyName(83, "more_v.png")
        Me.imgTVList.Images.SetKeyName(84, "music_beamed_note.png")
        Me.imgTVList.Images.SetKeyName(85, "music_eighth_note.png")
        Me.imgTVList.Images.SetKeyName(86, "music_library.png")
        Me.imgTVList.Images.SetKeyName(87, "network.png")
        Me.imgTVList.Images.SetKeyName(88, "notepad.png")
        Me.imgTVList.Images.SetKeyName(89, "paste.png")
        Me.imgTVList.Images.SetKeyName(90, "paste2.png")
        Me.imgTVList.Images.SetKeyName(91, "phone.png")
        Me.imgTVList.Images.SetKeyName(92, "phone_book.png")
        Me.imgTVList.Images.SetKeyName(93, "preview.png")
        Me.imgTVList.Images.SetKeyName(94, "print.png")
        Me.imgTVList.Images.SetKeyName(95, "printer.png")
        Me.imgTVList.Images.SetKeyName(96, "pyramid.png")
        Me.imgTVList.Images.SetKeyName(97, "radio_button_selected.png")
        Me.imgTVList.Images.SetKeyName(98, "radio_button_unselected.png")
        Me.imgTVList.Images.SetKeyName(99, "refresh.png")
        Me.imgTVList.Images.SetKeyName(100, "reload.png")
        Me.imgTVList.Images.SetKeyName(101, "round.png")
        Me.imgTVList.Images.SetKeyName(102, "scissors.png")
        Me.imgTVList.Images.SetKeyName(103, "send.png")
        Me.imgTVList.Images.SetKeyName(104, "share.png")
        Me.imgTVList.Images.SetKeyName(105, "speaker.png")
        Me.imgTVList.Images.SetKeyName(106, "speech_ballon.png")
        Me.imgTVList.Images.SetKeyName(107, "sphere.png")
        Me.imgTVList.Images.SetKeyName(108, "star.png")
        Me.imgTVList.Images.SetKeyName(109, "stats_pie_chart.png")
        Me.imgTVList.Images.SetKeyName(110, "system_file.png")
        Me.imgTVList.Images.SetKeyName(111, "technical_hammer.png")
        Me.imgTVList.Images.SetKeyName(112, "technical_screw.png")
        Me.imgTVList.Images.SetKeyName(113, "technical_wrench.png")
        Me.imgTVList.Images.SetKeyName(114, "toggle_off.png")
        Me.imgTVList.Images.SetKeyName(115, "toggle_on.png")
        Me.imgTVList.Images.SetKeyName(116, "traffic_lights.png")
        Me.imgTVList.Images.SetKeyName(117, "traffic_lights2.png")
        Me.imgTVList.Images.SetKeyName(118, "trash_can.png")
        Me.imgTVList.Images.SetKeyName(119, "upload.png")
        Me.imgTVList.Images.SetKeyName(120, "user.png")
        Me.imgTVList.Images.SetKeyName(121, "user_awake.png")
        Me.imgTVList.Images.SetKeyName(122, "user_female.png")
        Me.imgTVList.Images.SetKeyName(123, "user_sleep.png")
        Me.imgTVList.Images.SetKeyName(124, "webcam.png")
        Me.imgTVList.Images.SetKeyName(125, "window.png")
        Me.imgTVList.Images.SetKeyName(126, "windows.png")
        Me.imgTVList.Images.SetKeyName(127, "wizard.png")
        Me.imgTVList.Images.SetKeyName(128, "world.png")
        Me.imgTVList.Images.SetKeyName(129, "zoom.png")
        Me.imgTVList.Images.SetKeyName(130, "zoom_in.png")
        Me.imgTVList.Images.SetKeyName(131, "zoom_out.png")
        Me.imgTVList.Images.SetKeyName(132, "lims.png")
        '
        'lvListView
        '
        Me.lvListView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvListView.HideSelection = False
        Me.lvListView.LargeImageList = Me.imgTVListB
        Me.lvListView.Location = New System.Drawing.Point(225, 229)
        Me.lvListView.Name = "lvListView"
        Me.lvListView.Size = New System.Drawing.Size(459, 140)
        Me.lvListView.TabIndex = 13
        Me.lvListView.UseCompatibleStateImageBehavior = False
        '
        'imgTVListB
        '
        Me.imgTVListB.ImageStream = CType(resources.GetObject("imgTVListB.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgTVListB.TransparentColor = System.Drawing.Color.Transparent
        Me.imgTVListB.Images.SetKeyName(0, "add.png")
        Me.imgTVListB.Images.SetKeyName(1, "address_book.png")
        Me.imgTVListB.Images.SetKeyName(2, "administrator.png")
        Me.imgTVListB.Images.SetKeyName(3, "arrow_down.png")
        Me.imgTVListB.Images.SetKeyName(4, "arrow_down2.png")
        Me.imgTVListB.Images.SetKeyName(5, "arrow_left.png")
        Me.imgTVListB.Images.SetKeyName(6, "arrow_left2.png")
        Me.imgTVListB.Images.SetKeyName(7, "arrow_right.png")
        Me.imgTVListB.Images.SetKeyName(8, "arrow_right2.png")
        Me.imgTVListB.Images.SetKeyName(9, "arrow_up.png")
        Me.imgTVListB.Images.SetKeyName(10, "arrow_up2.png")
        Me.imgTVListB.Images.SetKeyName(11, "attachment.png")
        Me.imgTVListB.Images.SetKeyName(12, "audio_volume_high.png")
        Me.imgTVListB.Images.SetKeyName(13, "audio_volume_low.png")
        Me.imgTVListB.Images.SetKeyName(14, "audio_volume_medium.png")
        Me.imgTVListB.Images.SetKeyName(15, "audio_volume_mute.png")
        Me.imgTVListB.Images.SetKeyName(16, "audio_volume_none.png")
        Me.imgTVListB.Images.SetKeyName(17, "binoculars.png")
        Me.imgTVListB.Images.SetKeyName(18, "binoculars2.png")
        Me.imgTVListB.Images.SetKeyName(19, "book.png")
        Me.imgTVListB.Images.SetKeyName(20, "bookmark.png")
        Me.imgTVListB.Images.SetKeyName(21, "briefcase.png")
        Me.imgTVListB.Images.SetKeyName(22, "calculator.png")
        Me.imgTVListB.Images.SetKeyName(23, "calendar.png")
        Me.imgTVListB.Images.SetKeyName(24, "camera.png")
        Me.imgTVListB.Images.SetKeyName(25, "cancel.png")
        Me.imgTVListB.Images.SetKeyName(26, "chat.png")
        Me.imgTVListB.Images.SetKeyName(27, "chat_exclamation.png")
        Me.imgTVListB.Images.SetKeyName(28, "checkbox_check.png")
        Me.imgTVListB.Images.SetKeyName(29, "checkbox_cross.png")
        Me.imgTVListB.Images.SetKeyName(30, "checkbox_empty.png")
        Me.imgTVListB.Images.SetKeyName(31, "checkbox_round.png")
        Me.imgTVListB.Images.SetKeyName(32, "checkmark.png")
        Me.imgTVListB.Images.SetKeyName(33, "clip.png")
        Me.imgTVListB.Images.SetKeyName(34, "clipboard.png")
        Me.imgTVListB.Images.SetKeyName(35, "clock.png")
        Me.imgTVListB.Images.SetKeyName(36, "close.png")
        Me.imgTVListB.Images.SetKeyName(37, "copy.png")
        Me.imgTVListB.Images.SetKeyName(38, "copy2.png")
        Me.imgTVListB.Images.SetKeyName(39, "couple.png")
        Me.imgTVListB.Images.SetKeyName(40, "cross.png")
        Me.imgTVListB.Images.SetKeyName(41, "delete.png")
        Me.imgTVListB.Images.SetKeyName(42, "diary.png")
        Me.imgTVListB.Images.SetKeyName(43, "diskette.png")
        Me.imgTVListB.Images.SetKeyName(44, "document.png")
        Me.imgTVListB.Images.SetKeyName(45, "door.png")
        Me.imgTVListB.Images.SetKeyName(46, "download.png")
        Me.imgTVListB.Images.SetKeyName(47, "download2.png")
        Me.imgTVListB.Images.SetKeyName(48, "download3.png")
        Me.imgTVListB.Images.SetKeyName(49, "edit.png")
        Me.imgTVListB.Images.SetKeyName(50, "envelope.png")
        Me.imgTVListB.Images.SetKeyName(51, "envelope_open.png")
        Me.imgTVListB.Images.SetKeyName(52, "external_link.png")
        Me.imgTVListB.Images.SetKeyName(53, "file.png")
        Me.imgTVListB.Images.SetKeyName(54, "folder.png")
        Me.imgTVListB.Images.SetKeyName(55, "games_control.png")
        Me.imgTVListB.Images.SetKeyName(56, "games_deck_clubs.png")
        Me.imgTVListB.Images.SetKeyName(57, "games_deck_diamonds.png")
        Me.imgTVListB.Images.SetKeyName(58, "games_deck_hearts.png")
        Me.imgTVListB.Images.SetKeyName(59, "games_deck_spades.png")
        Me.imgTVListB.Images.SetKeyName(60, "games_dice.png")
        Me.imgTVListB.Images.SetKeyName(61, "gear.png")
        Me.imgTVListB.Images.SetKeyName(62, "group.png")
        Me.imgTVListB.Images.SetKeyName(63, "hand_point.png")
        Me.imgTVListB.Images.SetKeyName(64, "hand_share.png")
        Me.imgTVListB.Images.SetKeyName(65, "hand_thumbsdown.png")
        Me.imgTVListB.Images.SetKeyName(66, "hand_thumbsup.png")
        Me.imgTVListB.Images.SetKeyName(67, "help.png")
        Me.imgTVListB.Images.SetKeyName(68, "history.png")
        Me.imgTVListB.Images.SetKeyName(69, "history2.png")
        Me.imgTVListB.Images.SetKeyName(70, "history3.png")
        Me.imgTVListB.Images.SetKeyName(71, "home.png")
        Me.imgTVListB.Images.SetKeyName(72, "hourglass.png")
        Me.imgTVListB.Images.SetKeyName(73, "info.png")
        Me.imgTVListB.Images.SetKeyName(74, "lightbulb.png")
        Me.imgTVListB.Images.SetKeyName(75, "list.png")
        Me.imgTVListB.Images.SetKeyName(76, "lock_closed.png")
        Me.imgTVListB.Images.SetKeyName(77, "lock_open.png")
        Me.imgTVListB.Images.SetKeyName(78, "menu_bars.png")
        Me.imgTVListB.Images.SetKeyName(79, "microphone.png")
        Me.imgTVListB.Images.SetKeyName(80, "monitor.png")
        Me.imgTVListB.Images.SetKeyName(81, "more.png")
        Me.imgTVListB.Images.SetKeyName(82, "more_v.png")
        Me.imgTVListB.Images.SetKeyName(83, "music_beamed_note.png")
        Me.imgTVListB.Images.SetKeyName(84, "music_eighth_note.png")
        Me.imgTVListB.Images.SetKeyName(85, "music_library.png")
        Me.imgTVListB.Images.SetKeyName(86, "network.png")
        Me.imgTVListB.Images.SetKeyName(87, "notepad.png")
        Me.imgTVListB.Images.SetKeyName(88, "paste.png")
        Me.imgTVListB.Images.SetKeyName(89, "paste2.png")
        Me.imgTVListB.Images.SetKeyName(90, "phone.png")
        Me.imgTVListB.Images.SetKeyName(91, "phone_book.png")
        Me.imgTVListB.Images.SetKeyName(92, "preview.png")
        Me.imgTVListB.Images.SetKeyName(93, "print.png")
        Me.imgTVListB.Images.SetKeyName(94, "printer.png")
        Me.imgTVListB.Images.SetKeyName(95, "pyramid.png")
        Me.imgTVListB.Images.SetKeyName(96, "radio_button_selected.png")
        Me.imgTVListB.Images.SetKeyName(97, "radio_button_unselected.png")
        Me.imgTVListB.Images.SetKeyName(98, "refresh.png")
        Me.imgTVListB.Images.SetKeyName(99, "reload.png")
        Me.imgTVListB.Images.SetKeyName(100, "round.png")
        Me.imgTVListB.Images.SetKeyName(101, "scissors.png")
        Me.imgTVListB.Images.SetKeyName(102, "send.png")
        Me.imgTVListB.Images.SetKeyName(103, "share.png")
        Me.imgTVListB.Images.SetKeyName(104, "speaker.png")
        Me.imgTVListB.Images.SetKeyName(105, "speech_ballon.png")
        Me.imgTVListB.Images.SetKeyName(106, "sphere.png")
        Me.imgTVListB.Images.SetKeyName(107, "star.png")
        Me.imgTVListB.Images.SetKeyName(108, "stats_pie_chart.png")
        Me.imgTVListB.Images.SetKeyName(109, "system_file.png")
        Me.imgTVListB.Images.SetKeyName(110, "technical_hammer.png")
        Me.imgTVListB.Images.SetKeyName(111, "technical_screw.png")
        Me.imgTVListB.Images.SetKeyName(112, "technical_wrench.png")
        Me.imgTVListB.Images.SetKeyName(113, "toggle_off.png")
        Me.imgTVListB.Images.SetKeyName(114, "toggle_on.png")
        Me.imgTVListB.Images.SetKeyName(115, "traffic_lights.png")
        Me.imgTVListB.Images.SetKeyName(116, "traffic_lights2.png")
        Me.imgTVListB.Images.SetKeyName(117, "trash_can.png")
        Me.imgTVListB.Images.SetKeyName(118, "upload.png")
        Me.imgTVListB.Images.SetKeyName(119, "user.png")
        Me.imgTVListB.Images.SetKeyName(120, "user_awake.png")
        Me.imgTVListB.Images.SetKeyName(121, "user_female.png")
        Me.imgTVListB.Images.SetKeyName(122, "user_sleep.png")
        Me.imgTVListB.Images.SetKeyName(123, "webcam.png")
        Me.imgTVListB.Images.SetKeyName(124, "window.png")
        Me.imgTVListB.Images.SetKeyName(125, "windows.png")
        Me.imgTVListB.Images.SetKeyName(126, "wizard.png")
        Me.imgTVListB.Images.SetKeyName(127, "world.png")
        Me.imgTVListB.Images.SetKeyName(128, "zoom.png")
        Me.imgTVListB.Images.SetKeyName(129, "zoom_in.png")
        Me.imgTVListB.Images.SetKeyName(130, "zoom_out.png")
        Me.imgTVListB.Images.SetKeyName(131, "lims.png")
        '
        'lblMenu
        '
        Me.lblMenu.BackColor = System.Drawing.Color.White
        Me.lblMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblMenu.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenu.ForeColor = System.Drawing.Color.Black
        Me.lblMenu.Location = New System.Drawing.Point(230, 169)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(451, 18)
        Me.lblMenu.TabIndex = 17
        Me.lblMenu.Text = "No Menu is Selected."
        '
        'lblUser
        '
        Me.lblUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.lblUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblUser.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.White
        Me.lblUser.Location = New System.Drawing.Point(231, 86)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(615, 18)
        Me.lblUser.TabIndex = 16
        Me.lblUser.Text = "Logged On User : Muhammad Usman (01/02/2020 21:42 PM)"
        '
        'lblCompany
        '
        Me.lblCompany.BackColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.lblCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblCompany.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompany.ForeColor = System.Drawing.Color.White
        Me.lblCompany.Location = New System.Drawing.Point(231, 51)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(451, 26)
        Me.lblCompany.TabIndex = 15
        Me.lblCompany.Text = "Organisation Name"
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(231, 12)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(451, 28)
        Me.lblTitle.TabIndex = 14
        Me.lblTitle.Text = "medERP :: Medical ERP System."
        '
        'picListView
        '
        Me.picListView.BackColor = System.Drawing.Color.White
        Me.picListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picListView.Image = Global.medERP.My.Resources.Resources.listview_pic
        Me.picListView.Location = New System.Drawing.Point(224, 125)
        Me.picListView.Name = "picListView"
        Me.picListView.Size = New System.Drawing.Size(460, 238)
        Me.picListView.TabIndex = 12
        Me.picListView.TabStop = False
        '
        'picTitles
        '
        Me.picTitles.BackColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.picTitles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picTitles.Location = New System.Drawing.Point(224, 0)
        Me.picTitles.Name = "picTitles"
        Me.picTitles.Size = New System.Drawing.Size(622, 118)
        Me.picTitles.TabIndex = 10
        Me.picTitles.TabStop = False
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.Color.White
        Me.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLogo.Image = Global.medERP.My.Resources.Resources.ERP_Logo
        Me.picLogo.Location = New System.Drawing.Point(0, 0)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(217, 119)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picLogo.TabIndex = 9
        Me.picLogo.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tvTreeView)
        Me.Controls.Add(Me.lvListView)
        Me.Controls.Add(Me.lblMenu)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.lblCompany)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picListView)
        Me.Controls.Add(Me.picTitles)
        Me.Controls.Add(Me.picLogo)
        Me.KeyPreview = True
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "medERP"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picListView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTitles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tvTreeView As TreeView
    Friend WithEvents imgTVList As ImageList
    Friend WithEvents lvListView As ListView
    Friend WithEvents imgTVListB As ImageList
    Friend WithEvents lblMenu As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents lblCompany As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents picListView As PictureBox
    Friend WithEvents picTitles As PictureBox
    Friend WithEvents picLogo As PictureBox
End Class
