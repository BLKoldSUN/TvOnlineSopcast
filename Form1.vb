Public Class Form1
	' Aplicatia nu are bara de titlu
    'Declarea variabilelor
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True 'variabilele penru a putea muta mouse-ul
        mousex = Windows.Forms.Cursor.Position.X - Me.Left 'mouse in X
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top 'mouse in Y
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        'daca este activa functia drag, atunci do this
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False 'se opreste drag
    End Sub

    '##################################################################################################
    'Pornire program ##################################################################################
    '##################################################################################################
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SplitContainer1.Panel2Collapsed = True

        'Load setari aplicatie
        If My.Settings.statusminivideo = True Then
            Setari_aplicatie.ChkStatusMiniVideo.Checked = True
        Else
            Setari_aplicatie.ChkStatusMiniVideo.Checked = False
        End If

        ''Incarca lista de radiouri
        PicBox_radiolona.BackgroundImage = My.Resources.radiolona
        PicBox_1clubfm.BackgroundImage = My.Resources._1clubfm
        PicBox_clubdance.BackgroundImage = My.Resources.clubdance
        PicBox_clubdubstep.BackgroundImage = My.Resources.clubdubstep
        PicBox_clubtimefm.BackgroundImage = My.Resources.clubtimefm
        PicBox_hardbasefm.BackgroundImage = My.Resources.hardbasefm
        PicBox_housetimefm.BackgroundImage = My.Resources.housetimefm
        PicBox_parionetrance.BackgroundImage = My.Resources.parionetrance
        PicBox_sanantonio.BackgroundImage = My.Resources.sanantoniodance
        PicBox_skyfm.BackgroundImage = My.Resources.skyfm
        PicBox_technobase.BackgroundImage = My.Resources.technobase
        Picbox_tribalhouse.BackgroundImage = My.Resources.tribalhouse
        PicBox_vocaltrance.BackgroundImage = My.Resources.vocaltrance
        PicBox_radiozu.BackgroundImage = My.Resources.radiozu
        PicBox_europafm.BackgroundImage = My.Resources.ro_europafm
        PicBox_kissfm.BackgroundImage = My.Resources.ro_kissfm
        PicBox_magicfm.BackgroundImage = My.Resources.ro_magicfm
        PicBox_profm.BackgroundImage = My.Resources.ro_profm
        PicBox_radio24.BackgroundImage = My.Resources.ro_radio24
        PicBox_sporttotal.BackgroundImage = My.Resources.ro_sporttotal
    End Sub

    'Meniul pentru butonul de filme
    'HBO
    Private Sub HBOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HBOToolStripMenuItem.Click
        Player.SopAddress = "sop://broker.sopcast.com:3912/148881"
        Player.ChannelName = "HBO Romania"
        Player.Play()
    End Sub

    Private Sub HBOComedyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HBOComedyToolStripMenuItem.Click
        'HBO Comedy
        Player.SopAddress = "sop://broker.sopcast.com:3912/148883"
        Player.ChannelName = "HBO Comedy"
        Player.Play()
    End Sub

    Private Sub Server1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Server1ToolStripMenuItem.Click
        'Acasa TV S1
        Player.SopAddress = "sop://broker.sopcast.com:3912/148082"
        Player.ChannelName = "Acasa TV S1"
        Player.Play()
    End Sub

    Private Sub Server2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Server2ToolStripMenuItem.Click
        'Acasa TV S2
        Player.SopAddress = "sop://broker.sopcast.com:3912/122835"
        Player.ChannelName = "Acasa TV S2"
        Player.Play()
    End Sub

    Private Sub AcasaGoldToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcasaGoldToolStripMenuItem.Click
        'Acasa Gold
        Player.SopAddress = "sop://broker.sopcast.com:3912/148884"
        Player.ChannelName = "Acasa Gold"
        Player.Play()
    End Sub

    Private Sub UniversalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UniversalToolStripMenuItem.Click
        'Universal
        Player.SopAddress = "sop://broker.sopcast.com:3912/148255"
        Player.ChannelName = "Universal Channel"
        Player.Play()
    End Sub

    Private Sub AXNToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AXNToolStripMenuItem.Click
        'AXN Normal
        Player.SopAddress = "sop://broker.sopcast.com:3912/148257"
        Player.ChannelName = "AXN Channel"
        Player.Play()
    End Sub

    Private Sub AXNScifyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AXNScifyToolStripMenuItem.Click
        'AXN Sci-fy
        Player.SopAddress = "sop://broker.sopcast.com:3912/149262"
        Player.ChannelName = "AXN Sci-fy"
        Player.Play()
    End Sub

    Private Sub AXNCrimeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AXNCrimeToolStripMenuItem.Click
        'AXN Crime
        Player.SopAddress = "sop://broker.sopcast.com:3912/149261"
        Player.ChannelName = "AXN Crime"
        Player.Play()
    End Sub

    Private Sub AXNSpinToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AXNSpinToolStripMenuItem1.Click
        'AXN Spin
        Player.SopAddress = "sop://broker.sopcast.com:3912/149263"
        Player.ChannelName = "AXN Spin"
        Player.Play()
    End Sub

    Private Sub ProCinemaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProCinemaToolStripMenuItem.Click
        'Pro Cinema
        Player.SopAddress = "sop://broker.sopcast.com:3912/148249"
        Player.ChannelName = "Pro Cinema"
        Player.Play()
    End Sub

    Private Sub CinemaxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CinemaxToolStripMenuItem.Click
        'Cinemax
        Player.SopAddress = "sop://broker.sopcast.com:3912/140566"
        Player.ChannelName = "Cinemax"
        Player.Play()
    End Sub

    Private Sub FilmCafeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FilmCafeToolStripMenuItem.Click
        'Film Cafe
        Player.SopAddress = "sop://broker.sopcast.com:3912/120610"
        Player.ChannelName = "Film Cafe"
        Player.Play()
    End Sub

    Private Sub MGMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MGMToolStripMenuItem.Click
        'MGM
        Player.SopAddress = "sop://broker.sopcast.com:3912/120607"
        Player.ChannelName = "MGM Channel"
        Player.Play()
    End Sub

    Private Sub FilmBoxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FilmBoxToolStripMenuItem.Click
        'Movies
        Player.SopAddress = "sop://broker.sopcast.com:3912/120704"
        Player.ChannelName = "Movies Channel"
        Player.Play()
    End Sub

    Private Sub DivaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DivaToolStripMenuItem.Click
        'Diva
        Player.SopAddress = "sop://broker.sopcast.com:3912/148885"
        Player.ChannelName = "Diva Universal"
        Player.Play()
    End Sub

    Private Sub ProTVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProTVToolStripMenuItem.Click
        'PROTV
        Player.SopAddress = "sop://broker.sopcast.com:3912/148889"
        Player.ChannelName = "ProTV S1"
        Player.Play()
    End Sub

    Private Sub KanalDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KanalDToolStripMenuItem.Click
        'Kanal D
        Player.SopAddress = "sop://broker.sopcast.com:3912/148085"
        Player.ChannelName = "KanalD"
        Player.Play()
    End Sub

    Private Sub PrimaTVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrimaTVToolStripMenuItem.Click
        'Prima TV
        Player.SopAddress = "sop://broker.sopcast.com:3912/148086"
        Player.ChannelName = "Prima TV S1"
        Player.Play()
    End Sub

    Private Sub Antena1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Antena1ToolStripMenuItem.Click
        'Antena 1
        Player.SopAddress = "sop://broker.sopcast.com:3912/148083"
        Player.ChannelName = "Antena1 S1"
        Player.Play()
    End Sub



    'meniul de sport #########################################################

    Private Sub SportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SportToolStripMenuItem.Click
        'Sport 1
        Player.SopAddress = "sop://broker.sopcast.com:3912/150337"
        Player.ChannelName = "Sports TV S1"
        Player.Play()
    End Sub

    Private Sub GSPS1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GSPS1ToolStripMenuItem.Click
        'GSp 1
        Player.SopAddress = "sop://broker.sopcast.com:3912/127551"
        Player.ChannelName = "GSP S1"
        Player.Play()
    End Sub

    Private Sub SportroS1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SportroS1ToolStripMenuItem.Click
        'Sport.ro S1
        Player.SopAddress = "sop://broker.sopcast.com:3912/148882"
        Player.ChannelName = "Sport.ro S1"
        Player.Play()
    End Sub

    Private Sub Euro1S1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Euro1S1ToolStripMenuItem.Click
        'EuroSport1 S1
        Player.SopAddress = "sop://broker.sopcast.com:3912/148887"
        Player.ChannelName = "Eurosport1 S1"
        Player.Play()
    End Sub

    Private Sub Euro2S1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Euro2S1ToolStripMenuItem.Click
        'Eurosport2 S1
        Player.SopAddress = "sop://broker.sopcast.com:3912/124991"
        Player.ChannelName = "Eurosport2 S1"
        Player.Play()
    End Sub

    Private Sub DisneyChannelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisneyChannelToolStripMenuItem.Click
        'Disney Channel
        Player.SopAddress = "sop://broker.sopcast.com:3912/148252"
        Player.ChannelName = "Disney Channel"
        Player.Play()
    End Sub
    'Disney Channel - Server 1
    Private Sub Server1ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles Server1ToolStripMenuItem4.Click
        Player.SopAddress = "sop://broker.sopcast.com:3912/148252"
        Player.ChannelName = "Disney Channel - Server 1"
        Player.Play()
    End Sub

    Private Sub CartoonNetworkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CartoonNetworkToolStripMenuItem.Click
        'Cartoon Network
        Player.SopAddress = "sop://broker.sopcast.com:3912/148254"
        Player.ChannelName = "Cartoon Network"
        Player.Play()
    End Sub

    Private Sub NickelodeonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NickelodeonToolStripMenuItem.Click
        'Nickelodeon
        Player.SopAddress = "sop://broker.sopcast.com:3912/149265"
        Player.ChannelName = "Nickelodeon"
        Player.Play()
    End Sub

    Private Sub BoomerangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BoomerangToolStripMenuItem.Click
        'Jetix Junior
        Player.SopAddress = "sop://broker.sopcast.com:3912/148978"
        Player.ChannelName = "Jetix Junior"
        Player.Play()
    End Sub

    Private Sub MinimaxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinimaxToolStripMenuItem.Click
        'Minimax
        Player.SopAddress = "sop://broker.sopcast.com:3912/122837"
        Player.ChannelName = "Minimax"
        Player.Play()
    End Sub

    Private Sub DuckTVToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'DuckTV
        Player.SopAddress = "sop://broker.sopcast.com:3912/124991"
        Player.ChannelName = "Duck TV"
        Player.Play()
    End Sub


    Private Sub NationalGeogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NationalGeogToolStripMenuItem.Click
        'National G.
        Player.SopAddress = "sop://broker.sopcast.com:3912/148248"
        Player.ChannelName = "National Geographic"
        Player.Play()
    End Sub

    Private Sub HistoryChannelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistoryChannelToolStripMenuItem.Click
        'History Channel
        Player.SopAddress = "sop://broker.sopcast.com:3912/148253"
        Player.ChannelName = "History Channel"
        Player.Play()
    End Sub

    Private Sub BBCKnowledgeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BBCKnowledgeToolStripMenuItem.Click
        'BBC Knowledge
        Player.SopAddress = "sop://broker.sopcast.com:3912/124991"
        Player.ChannelName = "BBC Knowledge"
        Player.Play()
    End Sub

    Private Sub AnimalPlanetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnimalPlanetToolStripMenuItem.Click
        'Animal Planet
        Player.SopAddress = "sop://broker.sopcast.com:3912/74632"
        Player.ChannelName = "Animal Planet"
        Player.Play()
    End Sub

    Private Sub DiscoveryWorldToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiscoveryWorldToolStripMenuItem.Click
        'Disovery World
        Player.SopAddress = "sop://broker.sopcast.com:3912/148973"
        Player.ChannelName = "Disovery World"
        Player.Play()
    End Sub

    Private Sub DiscoveryScienceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiscoveryScienceToolStripMenuItem.Click
        'Discovery Science
        Player.SopAddress = "sop://broker.sopcast.com:3912/148974"
        Player.ChannelName = "Discovery Science"
        Player.Play()
    End Sub

    Private Sub DiscoveryChannelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiscoveryChannelToolStripMenuItem.Click
        'Discovery Channel
        Player.SopAddress = "sop://broker.sopcast.com:3912/148972"
        Player.ChannelName = "Discovery Channel"
        Player.Play()
    End Sub

    Private Sub DiscoveryTravellToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiscoveryTravellToolStripMenuItem.Click
        'TLC
        Player.SopAddress = "sop://broker.sopcast.com:3912/ 148977"
        Player.ChannelName = "TLC Channel"
        Player.Play()
    End Sub

    'Butonul pentru Youtube
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("http://www.youtube.com/user/andreiflorinpopescu")
    End Sub


    '#####################################################################################
    '#####################################################################################


    ' meniul radiourilor ###########################################################3
    Private Sub RadioLonaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'radio lona
        wmp.URL = "http://live.RadioLona.ro:8008/"
    End Sub

    Private Sub TechnoBaseFMToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'techno base fm
        wmp.URL = "http://listen.technobase.fm/tunein-mp3-asx"
    End Sub

    Private Sub HardBaseFMToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'hard base fm
        wmp.URL = "http://listen.hardbase.fm/tunein-mp3-asx"
    End Sub

    Private Sub HouseTimeFMToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'house time fm
        wmp.URL = "http://listen.housetime.fm/tunein-mp3-asx"
    End Sub

    Private Sub ClubTimeFMToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'clubetime fm
        wmp.URL = "http://listen.clubtime.fm/tunein-mp3-asx"
    End Sub

    Private Sub TranceBaseFMToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'Trance Base FM
        wmp.URL = "http://listen.trancebase.fm/tunein-mp3-asx"
    End Sub

    Private Sub KissFMToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'DeepHouse
        wmp.URL = "http://www.deephouselounge.com/Listen_Links/playlist.asx"
    End Sub

    Private Sub ElektroHouseToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'Elektro House
        wmp.URL = "http://listen.di.fm/public5/electro.asx"
    End Sub

    Private Sub RadioGangstaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'Radio Gangsta
        wmp.URL = "http://listen.radionomy.com/radiogansta.m3u"
    End Sub

    'meniul pentru tvr
    Private Sub TVR1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TVR1ToolStripMenuItem.Click
        'tvr1
        Player.SopAddress = "sop://broker.sopcast.com:3912/148256"
        Player.ChannelName = "TVR 1"
        Player.Play()
    End Sub

    Private Sub TVR2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TVR2ToolStripMenuItem.Click
        'tvr2
        Player.SopAddress = "sop://broker.sopcast.com:3912/148888"
        Player.ChannelName = "TVR 2"
        Player.Play()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Player.SopAddress = "sop://broker.sopcast.com:3912/" & Search.Text
        Player.Play()
    End Sub

    'ProTV Server 1 - CoolTV
    Private Sub CoolTVS1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoolTVS1ToolStripMenuItem.Click
        Player.SopAddress = "sop://broker.sopcast.com:3912/151929"
        Player.ChannelName = "ProTV - Server 1 - CoolTV"
        Player.Play()
    End Sub
    'ProTV Server 2 - CoolTV
    Private Sub CooltTVS2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CooltTVS2ToolStripMenuItem.Click
        Player.SopAddress = "sop://broker.sopcast.com:3912/149252"
        Player.ChannelName = "ProTV - Server 2 - CoolTV"
        Player.Play()
    End Sub
    'ProTV Server 3 - CoolTV
    Private Sub CoolTVS3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoolTVS3ToolStripMenuItem.Click
        Player.SopAddress = "sop://broker.sopcast.com:3912/122831"
        Player.ChannelName = "ProTV - Server 3 - CoolTV"
        Player.Play()
    End Sub
    'ProTV Server 4 - CoolTV
    Private Sub CoolTVS4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoolTVS4ToolStripMenuItem.Click
        Player.SopAddress = "sop://broker.sopcast.com:3912/90686"
        Player.ChannelName = "ProTV - Server 4 - CoolTV"
        Player.Play()
    End Sub

    'Sport server 1 ######################################################
    Private Sub CoolTVS1ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CoolTVS1ToolStripMenuItem1.Click
        Player.SopAddress = "sop://broker.sopcast.com:3912/ 173641"
        Player.ChannelName = "Sport TV - Server 1 - CoolTV"
        Player.Play()
    End Sub
    'Sport server 2
    Private Sub CoolTVS2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoolTVS2ToolStripMenuItem.Click
        Player.SopAddress = "sop://broker.sopcast.com:3912/124993"
        Player.ChannelName = "Sport TV - Server 1 - CoolTV"
        Player.Play()
    End Sub
    'Sport server 3
    Private Sub CoolTVS3ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CoolTVS3ToolStripMenuItem1.Click
        Player.SopAddress = "sop://broker.sopcast.com:3912/ 150341"
        Player.ChannelName = "Sport TV - Server 3 - CoolTV"
        Player.Play()
    End Sub
    'Sport server 4
    Private Sub CoolTVS4ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CoolTVS4ToolStripMenuItem1.Click
        Player.SopAddress = "sop://broker.sopcast.com:3912/148980"
        Player.ChannelName = "Sport TV - Server 4 - CoolTV"
        Player.Play()
    End Sub
    'Sport server 5
    Private Sub CoolTVS5ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoolTVS5ToolStripMenuItem.Click
        Player.SopAddress = "sop://broker.sopcast.com:3912/148982"
        Player.ChannelName = "Sport TV - Server 5 - CoolTV"
        Player.Play()
    End Sub
    'Sport server 6
    Private Sub CoolTVS6ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoolTVS6ToolStripMenuItem.Click
        Player.SopAddress = "sop://broker.sopcast.com:3912/148983"
        Player.ChannelName = "Sport TV - Server 6 - CoolTV"
        Player.Play()
    End Sub
    'GSP TV Server 1 Cool TV
    Private Sub CoolTVS1ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles CoolTVS1ToolStripMenuItem2.Click
        Player.SopAddress = "sop://broker.sopcast.com:3912/127551"
        Player.ChannelName = "GSP S1"
        Player.Play()
    End Sub
    'GSP TV Server 2 Cool TV
    Private Sub GSPTVorgS1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GSPTVorgS1ToolStripMenuItem.Click
        Player.SopAddress = "sop://broker.sopcast.com:3912/126977"
        Player.ChannelName = "GSP TV - Server 1 - GSPTV.ORG"
        Player.Play()
    End Sub
    'GSP Furat
    Private Sub GSPSS1FuratToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GSPSS1FuratToolStripMenuItem.Click
        Player.SopAddress = "sop://broker.sopcast.com:3912/126977"
        Player.ChannelName = "GSP TV"
        Player.Play()
    End Sub

    ''Soccer TV ######################################################################################
    'Soccer HD Server 1
    Private Sub Server1ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Server1ToolStripMenuItem1.Click
        Player.SopAddress = "sop://broker.sopcast.com:3912/139675"
        Player.ChannelName = "Soccer HD Server 1"
        Player.Play()
    End Sub
    'Soccer HD Server 2
    Private Sub Server2ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Server2ToolStripMenuItem1.Click
        Player.SopAddress = "sop://broker.sopcast.com:3912/120484"
        Player.ChannelName = "Soccer HD Server 2"
        Player.Play()
    End Sub



    'Soccer HD Server 3
    Private Sub Server3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Server3ToolStripMenuItem.Click
        Player.SopAddress = "sop://broker.sopcast.com:3912/93289"
        Player.ChannelName = "Soccer HD Server 2"
        Player.Play()
    End Sub
    'Soccer HD Server 4
    Private Sub Server4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Server4ToolStripMenuItem.Click
        Player.SopAddress = "sop://broker.sopcast.com:3912/132431"
        Player.ChannelName = "Soccer HD Server 2"
        Player.Play()
    End Sub

    ''Derby HD ########################################################################
    ''Server 1
    Private Sub Server1ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles Server1ToolStripMenuItem2.Click
        Player.SopAddress = "sop://broker.sopcast.com:3912/96441"
        Player.ChannelName = "Derby HD Server 1"
        Player.Play()
    End Sub
    'Server 2
    Private Sub Server2ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles Server2ToolStripMenuItem2.Click
        Player.SopAddress = "sop://broker.sopcast.com:3912/93290"
        Player.ChannelName = "Derby HD Server 2"
        Player.Play()
    End Sub
    'Server 3
    Private Sub Server3ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Server3ToolStripMenuItem1.Click
        Player.SopAddress = "sop://broker.sopcast.com:3912/124994"
        Player.ChannelName = "Derby HD Server 3"
        Player.Play()
    End Sub
    'Server 4
    Private Sub Server4ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Server4ToolStripMenuItem1.Click
        Player.SopAddress = "sop://broker.sopcast.com:3912/132431"
        Player.ChannelName = "Derby HD Server 4"
        Player.Play()
    End Sub

    'Live TV Football ##########################################################################
    'Server 1
    Private Sub Server1ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles Server1ToolStripMenuItem3.Click
        Player.SopAddress = "sop://broker.sopcast.com:3912/74348"
        Player.ChannelName = "Live TV Football - Server 1"
        Player.Play()
    End Sub
    'Server 2
    Private Sub Server2ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles Server2ToolStripMenuItem3.Click
        Player.SopAddress = "sop://broker.sopcast.com:3912/74750"
        Player.ChannelName = "Live TV Football - Server 2"
        Player.Play()
    End Sub
    'Server 3
    Private Sub Server3ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles Server3ToolStripMenuItem2.Click
        Player.SopAddress = "sop://broker.sopcast.com:3912/139462"
        Player.ChannelName = "Live TV Football - Server 3"
        Player.Play()
    End Sub
    'Server 4
    Private Sub Server4ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles Server4ToolStripMenuItem2.Click
        Player.SopAddress = "sop://broker.sopcast.com:3912/139463"
        Player.ChannelName = "Live TV Football - Server 4"
        Player.Play()
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        drag = True 'variabilele penru a putea muta mouse-ul
        mousex = Windows.Forms.Cursor.Position.X - Me.Left 'mouse in X
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top 'mouse in Y
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        drag = False 'se opreste drag
    End Sub

    'Butoanele de programe
    'generale
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.ContextMenuStrip1.Show(Me.Button5, New Point(0, 0))
    End Sub
    'sport
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.ContextMenuStrip2.Show(Me.Button6, New Point(0, 0))
    End Sub
    'desene animate
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.ContextMenuStrip3.Show(Me.Button7, New Point(0, 0))
    End Sub
    'culturale
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.ContextMenuStrip4.Show(Me.Button9, New Point(0, 0))
    End Sub

    '#######################################################################################
    'Radio Player ##########################################################################
    '#######################################################################################

    'deschide lista de radiouri
    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        'Me.ContextMenuStrip5.Show(Me.PictureBox7, New Point(0, 0))
        SplitContainer1.Panel2Collapsed = False
    End Sub
    'inchide lista de radiouri
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        SplitContainer1.Panel2Collapsed = True
    End Sub
    'butonul de stop
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        wmp.Ctlcontrols.stop()
        StatusRadio.Text = "Oprit"
    End Sub
    'play radio lona
    Private Sub PicBox_radiolona_Click(sender As Object, e As EventArgs) Handles PicBox_radiolona.Click
        wmp.URL = "http://live.radiolona.ro:8008"
        StatusRadio.Text = "Now playing: Radio Lona"
    End Sub

    Private Sub PicBox_1clubfm_Click(sender As Object, e As EventArgs) Handles PicBox_1clubfm.Click
        wmp.URL = "http://addictedtoradio.com/Listen/WMG/DanceHits.asx"
        StatusRadio.Text = "Now playing: 1Club FM"
    End Sub
    'play club dance
    Private Sub PicBox_clubdance_Click(sender As Object, e As EventArgs) Handles PicBox_clubdance.Click
        wmp.URL = "http://addictedtoradio.com/Listen/WMG/DanceHits.asx"
        StatusRadio.Text = "Now playing: ClubDance"
    End Sub
    'play club dubstep
    Private Sub PicBox_clubdubstep_Click(sender As Object, e As EventArgs) Handles PicBox_clubdubstep.Click
        wmp.URL = "http://listen.di.fm/public5/clubdubstep.asx"
        StatusRadio.Text = "Now playing: Club Dubstep"
    End Sub
    'play club time fm
    Private Sub PicBox_clubtimefm_Click(sender As Object, e As EventArgs) Handles PicBox_clubtimefm.Click
        wmp.URL = "http://listen.clubtime.fm/tunein-mp3-asx"
        StatusRadio.Text = "Now playing: ClubTime"
    End Sub
    'play hard base fm
    Private Sub PicBox_hardbasefm_Click(sender As Object, e As EventArgs) Handles PicBox_hardbasefm.Click
        wmp.URL = "http://listen.hardbase.fm/tunein-mp3-asx"
        StatusRadio.Text = "Now playing: HardBase FM"
    End Sub
    'play house time fm
    Private Sub PicBox_housetimefm_Click(sender As Object, e As EventArgs) Handles PicBox_housetimefm.Click
        wmp.URL = "http://listen.housetime.fm/tunein-mp3-asx"
        StatusRadio.Text = "Now playing: HouseTime FM"
    End Sub
    'play pari one trance
    Private Sub PicBox_parionetrance_Click(sender As Object, e As EventArgs) Handles PicBox_parionetrance.Click
        wmp.URL = "http://listen.radionomy.com/parisonetrance.asx"
        StatusRadio.Text = "Now playing: Paris Onetrance"
    End Sub
    'play san antonio
    Private Sub PicBox_sanantonio_Click(sender As Object, e As EventArgs) Handles PicBox_sanantonio.Click
        wmp.URL = "http://www.streamlicensing.com/stations/sadanceradio/playlistMediaPlayer.asx"
        StatusRadio.Text = "Now playing: San Antonio"
    End Sub
    'play sky fm
    Private Sub PicBox_skyfm_Click(sender As Object, e As EventArgs) Handles PicBox_skyfm.Click
        wmp.URL = "http://listen.sky.fm/public5/dreamscapes.asx"
        StatusRadio.Text = "Now playing: Sky.FM"
    End Sub
    'play techno base fm
    Private Sub PicBox_technobase_Click(sender As Object, e As EventArgs) Handles PicBox_technobase.Click
        wmp.URL = "http://listen.technobase.fm/tunein-mp3-asx"
        StatusRadio.Text = "Now playing: TechnoBase FM"
    End Sub
    'play tribal house
    Private Sub Picbox_tribalhouse_Click(sender As Object, e As EventArgs) Handles Picbox_tribalhouse.Click
        wmp.URL = "http://listen.di.fm/public5/tribalhouse.asx"
        StatusRadio.Text = "Now playing: Tribal House"
    End Sub
    'play vocal trance
    Private Sub PicBox_vocaltrance_Click(sender As Object, e As EventArgs) Handles PicBox_vocaltrance.Click
        wmp.URL = "http://listen.trancebase.fm/tunein-mp3-asx"
        StatusRadio.Text = "Now playing: Vocal trance"
    End Sub
    'play radiozu
    Private Sub PicBox_radiozu_Click(sender As Object, e As EventArgs) Handles PicBox_radiozu.Click
        wmp.URL = "http://stream.radiozu.ro:8020/"
        StatusRadio.Text = "Now playing: Radio Zu"
    End Sub
    'europafm
    Private Sub PicBox_europafm_Click(sender As Object, e As EventArgs) Handles PicBox_europafm.Click
        wmp.URL = "http://89.37.58.103:8000/"
        StatusRadio.Text = "Now playing: Europa FM"
    End Sub



    'Footer menu ##############################################
    '##########################################################

    'Close app
    Private Sub InchideAplicatiaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InchideAplicatiaToolStripMenuItem.Click
        Me.Close()
    End Sub

    'Minimizeaza
    Private Sub MinimizeazaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinimizeazaToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Minimized
        'daca este activa optiunea de afisare minivideo
        If My.Settings.statusminivideo = True Then
            MiniVideo.Show()
            MiniVideo.MiniPlayer.Play()
            Player.Stop()
        End If

        'daca este activa optiunea de afisare a meniului
        If My.Settings.meniuminivideo = True Then
            MiniVideo.ComboMiniMeniu.Visible = True
        Else
            MiniVideo.ComboMiniMeniu.Visible = False
        End If
    End Sub

    'Maximizeaza
    Private Sub MaximizeazaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaximizeazaToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    'Resetare dimensiune
    Private Sub ResetareDimensiuneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetareDimensiuneToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Normal
    End Sub

    'Deschide setarile
    Private Sub SetariAplicatieToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetariAplicatieToolStripMenuItem.Click
        Setari_aplicatie.Show()
    End Sub
    'Arata panoul de inregistrare si editare video
    Private Sub ProfilulTauToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfilulTauToolStripMenuItem.Click
        ProfilTV.Show()
    End Sub
End Class
